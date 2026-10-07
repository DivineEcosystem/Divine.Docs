using Docfx;
using Docfx.Common;
using Docfx.Dotnet;
using System.Text.Json.Nodes;
using System.Diagnostics;

namespace Divine.DocFx;

internal static class Bootstrap
{
    private static async Task<int> Main()
    {
        var generatedConfigPath = string.Empty;

        try
        {
            var docsRoot = GetRequiredDirectory("DIVINE_DOCS_ROOT");
            var configPath = Path.Combine(docsRoot, "src", "Divine.DocFx", "DocFx", "docfx.json");
            generatedConfigPath = Path.Combine(docsRoot, "docfx.generated.json");

            var config = await File.ReadAllTextAsync(configPath);
            var systemRoot = GetRequiredDirectory("DIVINE_SYSTEM_ROOT");
            config = config.Replace("{{DIVINE_SYSTEM_ROOT}}", systemRoot, StringComparison.Ordinal)
                           .Replace("{{DIVINE_DOCS_ROOT}}", docsRoot, StringComparison.Ordinal);
            config = ConfigureStandaloneRepository(config, systemRoot);
            await RestoreStandaloneProjects(config, systemRoot);
            await File.WriteAllTextAsync(generatedConfigPath, config);

            DeleteDirectory(Path.Combine(docsRoot, "_generated"));
            DeleteDirectory(Path.Combine(docsRoot, "_site"));

            Logger.ResetCount();
            await DotnetApiCatalog.GenerateManagedReferenceYamlFiles(generatedConfigPath);
            if (Logger.HasError)
            {
                return 1;
            }

            var apiMarkdown = Path.Combine(docsRoot, "_generated", "markdown");
            if (!Directory.Exists(apiMarkdown)
                || !Directory.EnumerateFiles(apiMarkdown, "*.md", SearchOption.AllDirectories).Any())
            {
                throw new InvalidOperationException("No API Markdown was generated. Check DIVINE_SYSTEM_ROOT and the metadata source paths in docfx.json.");
            }

            await Docset.Build(generatedConfigPath);
            if (Logger.HasError)
            {
                return 1;
            }

            await WriteLlmIndex(docsRoot);
            return 0;
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e);
            return 1;
        }
        finally
        {
            if (File.Exists(generatedConfigPath))
            {
                File.Delete(generatedConfigPath);
            }
        }
    }

    private static string ConfigureStandaloneRepository(string config, string systemRoot)
    {
        if (!File.Exists(Path.Combine(systemRoot, "src", "Divine", "Divine.csproj")))
        {
            return config;
        }

        var appRoot = Environment.GetEnvironmentVariable("DIVINE_APP_ROOT");
        if (string.IsNullOrWhiteSpace(appRoot))
        {
            var clientConfig = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Divine", "Divine.Client.json");
            if (File.Exists(clientConfig))
            {
                appRoot = JsonNode.Parse(File.ReadAllText(clientConfig))?["BaseDirectory"]?.GetValue<string>();
            }
        }

        if (string.IsNullOrWhiteSpace(appRoot)
            || !File.Exists(Path.Combine(appRoot, "References", "Divine.Common.dll")))
        {
            throw new InvalidOperationException("Standalone Divine documentation requires an installed Divine runtime. Set DIVINE_APP_ROOT to the directory containing References/Divine.Common.dll.");
        }

        appRoot = Path.GetFullPath(appRoot).Replace('\\', '/').TrimEnd('/');
        var document = JsonNode.Parse(config)!;
        foreach (var metadata in document["metadata"]!.AsArray())
        {
            if (metadata!["references"] is { } references)
            {
                metadata["src"] = new JsonObject
                {
                    ["src"] = appRoot + "/References/",
                    ["files"] = new JsonArray("Divine.Common.dll")
                };
                references[0]!["src"] = appRoot + "/Dependencies/";
                continue;
            }

            metadata!["src"] = new JsonObject
            {
                ["src"] = systemRoot,
                ["files"] = new JsonArray(
                    "src/Divine/Divine.csproj",
                    "src/Divine.Extensions/Divine.Extensions.csproj")
            };
            metadata["properties"]!["AppBasePath"] = appRoot + "/";
            metadata["properties"]!["IsInternal"] = "false";
            metadata["properties"]!["SolutionName"] = "Divine";
            metadata["properties"]!["UseDivineFrameworkDependencies"] = "true";
            metadata["properties"]!["UseDivineDependencies"] = "true";
            metadata["properties"]!["UseDivineProtobufs"] = "true";
            metadata["noRestore"] = true;
        }

        Console.WriteLine($"Generating API documentation from standalone repository {systemRoot} using runtime {appRoot}.");
        return document.ToJsonString();
    }

    private static async Task RestoreStandaloneProjects(string config, string systemRoot)
    {
        var project = Path.Combine(systemRoot, "src", "Divine", "Divine.csproj");
        if (!File.Exists(project))
        {
            return;
        }

        // DocFX's implicit restore does not forward the metadata MSBuild properties.
        var startInfo = new ProcessStartInfo("dotnet") { UseShellExecute = false };
        startInfo.ArgumentList.Add("restore");
        startInfo.ArgumentList.Add(project);
        foreach (var property in JsonNode.Parse(config)!["metadata"]![0]!["properties"]!.AsObject())
        {
            startInfo.ArgumentList.Add($"-p:{property.Key}={property.Value!.GetValue<string>()}");
        }

        using var process = Process.Start(startInfo)
            ?? throw new InvalidOperationException("Could not start dotnet restore.");
        await process.WaitForExitAsync();
        if (process.ExitCode != 0)
        {
            throw new InvalidOperationException($"Divine API project restore failed with exit code {process.ExitCode}.");
        }
    }

    private static async Task WriteLlmIndex(string docsRoot)
    {
        var siteRoot = Path.Combine(docsRoot, "_site");
        var markdownRoot = Path.Combine(siteRoot, "markdown");
        var sourceRoot = Path.Combine(docsRoot, "src", "Divine.DocFx", "DocFx");
        foreach (var source in Directory.EnumerateFiles(sourceRoot, "*", SearchOption.AllDirectories))
        {
            var relativePath = Path.GetRelativePath(sourceRoot, source);
            if (!source.EndsWith(".md", StringComparison.OrdinalIgnoreCase)
                && !relativePath.StartsWith($"images{Path.DirectorySeparatorChar}", StringComparison.Ordinal))
            {
                continue;
            }

            var destination = Path.Combine(markdownRoot, relativePath);
            Directory.CreateDirectory(Path.GetDirectoryName(destination)!);
            File.Copy(source, destination, overwrite: true);
        }

        var lines = new List<string>
        {
            "# Divine documentation",
            "",
            "> Divine guides and API reference in Markdown.",
            "",
            "## Documentation",
            ""
        };

        foreach (var file in Directory.EnumerateFiles(markdownRoot, "*.md", SearchOption.AllDirectories)
                                      .Order(StringComparer.Ordinal))
        {
            var relativePath = Path.GetRelativePath(siteRoot, file).Replace('\\', '/');
            var url = string.Join("/", relativePath.Split('/').Select(Uri.EscapeDataString));
            var label = Path.GetRelativePath(markdownRoot, file).Replace('\\', '/');
            lines.Add($"- [{label}]({url})");
        }

        await File.WriteAllLinesAsync(Path.Combine(siteRoot, "llms.txt"), lines);
    }

    private static string GetRequiredDirectory(string variableName)
    {
        var path = Environment.GetEnvironmentVariable(variableName);
        if (string.IsNullOrWhiteSpace(path))
        {
            throw new InvalidOperationException($"The {variableName} environment variable is required.");
        }

        path = Path.GetFullPath(path);
        if (!Directory.Exists(path))
        {
            throw new DirectoryNotFoundException($"The directory specified by {variableName} does not exist: {path}");
        }

        return path.Replace('\\', '/');
    }

    private static void DeleteDirectory(string path)
    {
        path = Path.GetFullPath(path);
        if (Directory.Exists(path))
        {
            Directory.Delete(path, true);
        }
    }
}

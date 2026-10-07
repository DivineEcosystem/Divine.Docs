using Docfx;
using Docfx.Common;
using Docfx.Dotnet;

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

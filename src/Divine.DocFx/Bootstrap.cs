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
            config = config.Replace("{{DIVINE_SYSTEM_ROOT}}", GetRequiredDirectory("DIVINE_SYSTEM_ROOT"), StringComparison.Ordinal)
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

            await Docset.Build(generatedConfigPath);
            return Logger.HasError ? 1 : 0;
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

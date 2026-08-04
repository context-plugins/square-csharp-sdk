using Square.Core.Models;

namespace Square.Servers;

public class DefaultOptions
{
    public ProductionOptions Production { get; set; } = new();
    public SandboxOptions Sandbox { get; set; } = new();
    public CustomOptions Custom { get; set; } = new();

    internal UrlTemplate Resolve(ServerEnvironment environment, string path) =>
        environment.Match(() => new UrlTemplate(Production.BaseUrl, path, []),
            () => new UrlTemplate(Sandbox.BaseUrl, path, []),
            () => new UrlTemplate(Custom.BaseUrl, path, [TemplateParam.ForServer("custom_url", Custom.CustomUrl)]));

    public class ProductionOptions
    {
        public string BaseUrl { get; set; } = "https://connect.squareup.com";
    }

    public class SandboxOptions
    {
        public string BaseUrl { get; set; } = "https://connect.squareupsandbox.com";
    }

    public class CustomOptions
    {
        public string BaseUrl { get; set; } = "{custom_url}";
        public string CustomUrl { get; set; } = "https://connect.squareup.com";
    }
}

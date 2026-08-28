using System.Collections.Generic;
using Square.Core.Authentication.OAuth2;
using Square.Core.Authentication.OAuth2.AuthorizationCode;
using Square.Core.Configuration;
using Square.Core.Hooks;
using Square.Servers;

namespace Square;

public class SquareClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    public IReadOnlyList<SdkHook> Hooks { get; set; } = [];
    public OAuth2AuthorizationCodeCredentials? Oauth2 { get; set; }
    public IOAuth2RefreshableTokenStrategy<OAuth2AuthorizationCodeCredentials>? Oauth2TokenStrategy { get; set; }
    public string? Oauth2ClientSecret { get; set; }
}

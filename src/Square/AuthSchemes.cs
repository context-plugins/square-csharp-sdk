using Square.Core;
using Square.Core.Authentication;
using Square.Core.Authentication.ApiKey;
using Square.Core.Authentication.OAuth2;
using Square.Core.Authentication.OAuth2.AuthorizationCode;

namespace Square;

internal sealed class AuthSchemes
{
    public IAuthScheme Oauth2ClientSecret { get; }
    public IAuthScheme Oauth2 { get; }

    public AuthSchemes(SquareClientOptions options, Server server, RawClient rawClient, UriFactory urlFactory)
    {
        Oauth2ClientSecret = ApiKeyHeaderScheme.Create("Authorization", options.Oauth2ClientSecret);
        Oauth2 =
            OAuth2RefreshableScheme<OAuth2AuthorizationCodeCredentials>.Create(
                options.Oauth2,
                options.Oauth2TokenStrategy ??
                    OAuth2AuthorizationCodeStrategy.ForBasicAuthRequest(
                        server.Default("/oauth2/authorize"),
                        server.Default("/oauth2/token"),
                        rawClient,
                        urlFactory),
                options.TimeProvider);
    }
}

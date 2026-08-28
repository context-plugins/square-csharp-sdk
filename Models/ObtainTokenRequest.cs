using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an <see href="api-endpoint:OAuth-ObtainToken">ObtainToken</see> request.
/// </summary>
public record ObtainTokenRequest
{
    /// <summary>
    /// The Square-issued ID of your application, which is available as the <b>Application ID</b>
    /// on the <b>OAuth</b> page in the <see href="https://developer.squareup.com/apps">Developer Console</see>.
    /// <para>
    /// Required for the code flow and PKCE flow for any grant type.
    /// </para>
    /// </summary>
    [JsonPropertyName("client_id")]
    [MaxLength(191)]
    public required string ClientId { get; init; }

    /// <summary>
    /// The secret key for your application, which is available as the <b>Application secret</b>
    /// on the <b>OAuth</b> page in the <see href="https://developer.squareup.com/apps">Developer Console</see>.
    /// <para>
    /// Required for the code flow for any grant type. Don't confuse your client secret with your
    /// personal access token.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_secret")]
    [StringLength(1024, MinimumLength = 2)]
    public string? ClientSecret { get; init; }

    /// <summary>
    /// The authorization code to exchange for an OAuth access token. This is the <c>code</c>
    /// value that Square sent to your redirect URL in the authorization response.
    /// <para>
    /// Required for the code flow and PKCE flow if <c>grant_type</c> is <c>authorization_code</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    [MaxLength(191)]
    public string? Code { get; init; }

    /// <summary>
    /// The redirect URL for your application, which you registered as the <b>Redirect URL</b>
    /// on the <b>OAuth</b> page in the <see href="https://developer.squareup.com/apps">Developer Console</see>.
    /// <para>
    /// Required for the code flow and PKCE flow if <c>grant_type</c> is <c>authorization_code</c> and
    /// you provided the <c>redirect_uri</c> parameter in your authorization URL.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirect_uri")]
    [MaxLength(2048)]
    public string? RedirectUri { get; init; }

    /// <summary>
    /// The method used to obtain an OAuth access token. The request must include the
    /// credential that corresponds to the specified grant type. Valid values are:
    /// - <c>authorization_code</c> - Requires the <c>code</c> field.
    /// - <c>refresh_token</c> - Requires the <c>refresh_token</c> field.
    /// - <c>migration_token</c> - LEGACY for access tokens obtained using a Square API version prior
    /// to 2019-03-13. Requires the <c>migration_token</c> field.
    /// </summary>
    [JsonPropertyName("grant_type")]
    [StringLength(20, MinimumLength = 10)]
    public required string GrantType { get; init; }

    /// <summary>
    /// A valid refresh token used to generate a new OAuth access token. This is a
    /// refresh token that was returned in a previous <c>ObtainToken</c> response.
    /// <para>
    /// Required for the code flow and PKCE flow if <c>grant_type</c> is <c>refresh_token</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refresh_token")]
    [StringLength(1024, MinimumLength = 2)]
    public string? RefreshToken { get; init; }

    /// <summary>
    /// __LEGACY__ A valid access token (obtained using a Square API version prior to 2019-03-13)
    /// used to generate a new OAuth access token.
    /// <para>
    /// Required if <c>grant_type</c> is <c>migration_token</c>. For more information, see
    /// <see href="https://developer.squareup.com/docs/oauth-api/migrate-to-refresh-tokens">Migrate to Using Refresh Tokens</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("migration_token")]
    [StringLength(1024, MinimumLength = 2)]
    public string? MigrationToken { get; init; }

    /// <summary>
    /// The list of permissions that are explicitly requested for the access token.
    /// For example, ["MERCHANT_PROFILE_READ","PAYMENTS_READ","BANK_ACCOUNTS_READ"].
    /// <para>
    /// The returned access token is limited to the permissions that are the intersection
    /// of these requested permissions and those authorized by the provided <c>refresh_token</c>.
    /// </para>
    /// <para>
    /// Optional for the code flow and PKCE flow if <c>grant_type</c> is <c>refresh_token</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scopes")]
    public IReadOnlyList<string?>? Scopes { get; init; }

    /// <summary>
    /// Indicates whether the returned access token should expire in 24 hours.
    /// <para>
    /// Optional for the code flow and PKCE flow for any grant type. The default value is <c>false</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("short_lived")]
    public bool? ShortLived { get; init; }

    /// <summary>
    /// The secret your application generated for the authorization request used to
    /// obtain the authorization code. This is the source of the <c>code_challenge</c> hash you
    /// provided in your authorization URL.
    /// <para>
    /// Required for the PKCE flow if <c>grant_type</c> is <c>authorization_code</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code_verifier")]
    public string? CodeVerifier { get; init; }

    /// <summary>
    /// Indicates whether to use a JWT (JSON Web Token) as the OAuth access token.
    /// When set to <c>true</c>, the OAuth flow returns a JWT to your application, used in the
    /// same way as a regular token. The default value is <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("use_jwt")]
    public bool? UseJwt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

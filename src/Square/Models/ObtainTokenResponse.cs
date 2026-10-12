using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an <see href="api-endpoint:OAuth-ObtainToken">ObtainToken</see> response.
/// </summary>
public record ObtainTokenResponse
{
    /// <summary>
    /// An OAuth access token used to authorize Square API requests on behalf of the seller.
    /// Include this token as a bearer token in the <c>Authorization</c> header of your API requests.
    /// <para>
    /// OAuth access tokens expire in 30 days (except <c>short_lived</c> access tokens). You should call
    /// <c>ObtainToken</c> and provide the returned <c>refresh_token</c> to get a new access token well before
    /// the current one expires. For more information, see <see href="https://developer.squareup.com/docs/oauth-api/walkthrough">OAuth API: Walkthrough</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("access_token")]
    [StringLength(1024, MinimumLength = 2)]
    public string? AccessToken { get; init; }

    /// <summary>
    /// The type of access token. This value is always <c>bearer</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token_type")]
    [StringLength(10, MinimumLength = 2)]
    public string? TokenType { get; init; }

    /// <summary>
    /// The timestamp of when the <c>access_token</c> expires, in <see href="http://www.iso.org/iso/home/standards/iso8601.htm">ISO 8601</see> format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expires_at")]
    [StringLength(48, MinimumLength = 20)]
    public string? ExpiresAt { get; init; }

    /// <summary>
    /// The ID of the authorizing <see href="entity:Merchant">merchant</see> (seller), which represents a business.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_id")]
    [StringLength(191, MinimumLength = 8)]
    public string? MerchantId { get; init; }

    /// <summary>
    /// __LEGACY__ The ID of merchant's subscription.
    /// The ID is only present if the merchant signed up for a subscription plan during authorization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription_id")]
    public string? SubscriptionId { get; init; }

    /// <summary>
    /// __LEGACY__ The ID of the subscription plan the merchant signed
    /// up for. The ID is only present if the merchant signed up for a subscription plan during
    /// authorization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plan_id")]
    public string? PlanId { get; init; }

    /// <summary>
    /// The OpenID token that belongs to this person. This token is only present if the
    /// <c>OPENID</c> scope is included in the authorization request.
    /// <para>
    /// Deprecated at version 2021-09-15. Square doesn't support OpenID or other single sign-on (SSO)
    /// protocols on top of OAuth.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id_token")]
    public string? IdToken { get; init; }

    /// <summary>
    /// A refresh token that can be used in an <c>ObtainToken</c> request to generate a new access token.
    /// <para>
    /// With the code flow:
    /// - For the <c>authorization_code</c> grant type, the refresh token is multi-use and never expires.
    /// - For the <c>refresh_token</c> grant type, the response returns the same refresh token.
    /// </para>
    /// <para>
    /// With the PKCE flow:
    /// - For the <c>authorization_code</c> grant type, the refresh token is single-use and expires in 90 days.
    /// - For the <c>refresh_token</c> grant type, the refresh token is a new single-use refresh token that expires in 90 days.
    /// </para>
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/oauth-api/refresh-revoke-limit-scope">Refresh, Revoke, and Limit the Scope of OAuth Tokens</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refresh_token")]
    [StringLength(1024, MinimumLength = 2)]
    public string? RefreshToken { get; init; }

    /// <summary>
    /// Indicates whether the access_token is short lived. If <c>true</c>, the access token expires
    /// in 24 hours. If <c>false</c>, the access token expires in 30 days.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("short_lived")]
    public bool? ShortLived { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The timestamp of when the <c>refresh_token</c> expires, in <see href="http://www.iso.org/iso/home/standards/iso8601.htm">ISO 8601</see>
    /// format.
    /// <para>
    /// This field is only returned for the PKCE flow.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refresh_token_expires_at")]
    [StringLength(48, MinimumLength = 20)]
    public string? RefreshTokenExpiresAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

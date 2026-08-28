using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record RevokeTokenRequest
{
    /// <summary>
    /// The Square-issued ID for your application, which is available on the <b>OAuth</b> page in the
    /// <see href="https://developer.squareup.com/apps">Developer Dashboard</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    [MaxLength(191)]
    public string? ClientId { get; init; }

    /// <summary>
    /// The access token of the merchant whose token you want to revoke.
    /// Do not provide a value for <c>merchant_id</c> if you provide this parameter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("access_token")]
    [StringLength(1024, MinimumLength = 2)]
    public string? AccessToken { get; init; }

    /// <summary>
    /// The ID of the merchant whose token you want to revoke.
    /// Do not provide a value for <c>access_token</c> if you provide this parameter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; init; }

    /// <summary>
    /// If <c>true</c>, terminate the given single access token, but do not
    /// terminate the entire authorization.
    /// Default: <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("revoke_only_access_token")]
    public bool? RevokeOnlyAccessToken { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

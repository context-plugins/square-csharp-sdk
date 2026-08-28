using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

public record OauthAuthorizationRevokedEventRevocationObject
{
    /// <summary>
    /// Timestamp of when the revocation event occurred, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("revoked_at")]
    public string? RevokedAt { get; init; }

    /// <summary>
    /// Defines the possible types for the revoking client.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("revoker_type")]
    public OauthAuthorizationRevokedEventRevokerType? RevokerType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

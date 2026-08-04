using System.Text.Json.Serialization;

namespace Square.Models;

public record OauthAuthorizationRevokedEventObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("revocation")]
    public OauthAuthorizationRevokedEventRevocationObject? Revocation { get; init; }
}

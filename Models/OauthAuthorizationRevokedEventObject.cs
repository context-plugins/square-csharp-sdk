using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record OauthAuthorizationRevokedEventObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("revocation")]
    public OauthAuthorizationRevokedEventRevocationObject? Revocation { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

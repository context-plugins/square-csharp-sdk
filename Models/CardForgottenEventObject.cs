using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record CardForgottenEventObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public CardForgottenEventCard? Card { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

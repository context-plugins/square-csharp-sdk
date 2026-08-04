using System.Text.Json.Serialization;

namespace Square.Models;

public record CardForgottenEventObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public CardForgottenEventCard? Card { get; init; }
}

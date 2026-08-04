using System.Text.Json.Serialization;

namespace Square.Models;

public record ConfirmationDecision
{
    /// <summary>
    /// The buyer's decision to the displayed terms.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("has_agreed")]
    public bool? HasAgreed { get; init; }
}

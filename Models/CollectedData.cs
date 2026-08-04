using System.Text.Json.Serialization;

namespace Square.Models;

public record CollectedData
{
    /// <summary>
    /// The buyer's input text.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("input_text")]
    public string? InputText { get; init; }
}

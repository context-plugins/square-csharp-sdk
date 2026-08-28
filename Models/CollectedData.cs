using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record CollectedData
{
    /// <summary>
    /// The buyer's input text.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("input_text")]
    public string? InputText { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

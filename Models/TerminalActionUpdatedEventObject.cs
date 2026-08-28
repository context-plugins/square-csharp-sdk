using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record TerminalActionUpdatedEventObject
{
    /// <summary>
    /// Represents an action processed by the Square Terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public TerminalAction? Action { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;

namespace Square.Models;

public record TerminalActionUpdatedEventObject
{
    /// <summary>
    /// Represents an action processed by the Square Terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public TerminalAction? Action { get; init; }
}

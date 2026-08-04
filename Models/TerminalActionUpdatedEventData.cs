using System.Text.Json.Serialization;

namespace Square.Models;

public record TerminalActionUpdatedEventData
{
    /// <summary>
    /// Name of the updated object’s type, <c>"action"</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// ID of the updated terminal action.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object")]
    public TerminalActionUpdatedEventObject? Object { get; init; }
}

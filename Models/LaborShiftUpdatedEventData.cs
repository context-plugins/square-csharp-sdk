using System.Text.Json.Serialization;

namespace Square.Models;

public record LaborShiftUpdatedEventData
{
    /// <summary>
    /// The type of object affected by the event. For this event, the value is <c>shift</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// ID of the affected <c>Shift</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object")]
    public LaborShiftUpdatedEventObject? Object { get; init; }
}

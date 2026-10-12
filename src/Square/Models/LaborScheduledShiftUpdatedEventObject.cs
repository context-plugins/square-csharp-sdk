using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record LaborScheduledShiftUpdatedEventObject
{
    /// <summary>
    /// Represents a specific time slot in a work schedule. This object is used to manage the
    /// lifecycle of a scheduled shift from the draft to published state. A scheduled shift contains
    /// the latest draft shift details and current published shift details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ScheduledShift")]
    public ScheduledShift? ScheduledShift { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

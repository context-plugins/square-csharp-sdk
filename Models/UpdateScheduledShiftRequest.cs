using System.Text.Json.Serialization;

namespace Square.Models;

public record UpdateScheduledShiftRequest
{
    /// <summary>
    /// Represents a specific time slot in a work schedule. This object is used to manage the
    /// lifecycle of a scheduled shift from the draft to published state. A scheduled shift contains
    /// the latest draft shift details and current published shift details.
    /// </summary>
    [JsonPropertyName("scheduled_shift")]
    public required ScheduledShift ScheduledShift { get; init; }
}

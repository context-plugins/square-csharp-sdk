using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:Labor-RetrieveScheduledShift">RetrieveScheduledShift</see> response.
/// Either <c>scheduled_shift</c> or <c>errors</c> is present in the response.
/// </summary>
public record RetrieveScheduledShiftResponse
{
    /// <summary>
    /// Represents a specific time slot in a work schedule. This object is used to manage the
    /// lifecycle of a scheduled shift from the draft to published state. A scheduled shift contains
    /// the latest draft shift details and current published shift details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheduled_shift")]
    public ScheduledShift? ScheduledShift { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}

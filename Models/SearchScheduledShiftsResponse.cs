using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:Labor-SearchScheduledShifts">SearchScheduledShifts</see> response.
/// Either <c>scheduled_shifts</c> or <c>errors</c> is present in the response.
/// </summary>
public record SearchScheduledShiftsResponse
{
    /// <summary>
    /// A paginated list of scheduled shifts that match the query conditions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheduled_shifts")]
    public IReadOnlyList<ScheduledShift>? ScheduledShifts { get; init; }

    /// <summary>
    /// The pagination cursor used to retrieve the next page of results. This field is present
    /// only if additional results are available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}

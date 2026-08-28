using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// The response to a request to create a <c>Shift</c>. The response contains
/// the created <c>Shift</c> object and might contain a set of <c>Error</c> objects if
/// the request resulted in errors.
/// </summary>
public record CreateShiftResponse
{
    /// <summary>
    /// A record of the hourly rate, start, and end times for a single work shift
    /// for an employee. This might include a record of the start and end times for breaks
    /// taken during the shift.
    /// <para>
    /// Deprecated at Square API version 2025-05-21. Replaced by <see href="entity:Timecard">Timecard</see>.
    /// See the <see href="https://developer.squareup.com/docs/labor-api/what-it-does#migration-notes">migration notes</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shift")]
    public Shift? Shift { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

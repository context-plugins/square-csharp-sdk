using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// A request to update a <c>Shift</c> object.
/// </summary>
public record UpdateShiftRequest
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
    [JsonPropertyName("shift")]
    public required Shift Shift { get; init; }
}

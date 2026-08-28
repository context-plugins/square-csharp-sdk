using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// A request to update a <c>Timecard</c> object.
/// </summary>
public record UpdateTimecardRequest
{
    /// <summary>
    /// A record of the hourly rate, start time, and end time of a single timecard (shift)
    /// for a team member. This might include a record of the start and end times of breaks
    /// taken during the shift.
    /// </summary>
    [JsonPropertyName("timecard")]
    public required Timecard Timecard { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

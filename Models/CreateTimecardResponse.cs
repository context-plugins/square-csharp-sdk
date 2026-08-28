using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// The response to a request to create a <c>Timecard</c>. The response contains
/// the created <c>Timecard</c> object and might contain a set of <c>Error</c> objects if
/// the request resulted in errors.
/// </summary>
public record CreateTimecardResponse
{
    /// <summary>
    /// A record of the hourly rate, start time, and end time of a single timecard (shift)
    /// for a team member. This might include a record of the start and end times of breaks
    /// taken during the shift.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timecard")]
    public Timecard? Timecard { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

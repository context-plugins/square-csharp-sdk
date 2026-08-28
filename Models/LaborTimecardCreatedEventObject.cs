using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record LaborTimecardCreatedEventObject
{
    /// <summary>
    /// A record of the hourly rate, start time, and end time of a single timecard (shift)
    /// for a team member. This might include a record of the start and end times of breaks
    /// taken during the shift.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timecard")]
    public Timecard? Timecard { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a request to create a <c>Timecard</c>.
/// </summary>
public record CreateTimecardRequest
{
    /// <summary>
    /// A unique string value to ensure the idempotency of the operation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [MaxLength(128)]
    public string? IdempotencyKey { get; init; }

    /// <summary>
    /// A record of the hourly rate, start time, and end time of a single timecard (shift)
    /// for a team member. This might include a record of the start and end times of breaks
    /// taken during the shift.
    /// </summary>
    [JsonPropertyName("timecard")]
    public required Timecard Timecard { get; init; }
}

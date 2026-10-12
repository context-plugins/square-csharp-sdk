using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a request to create a <c>Shift</c>.
/// </summary>
public record CreateShiftRequest
{
    /// <summary>
    /// A unique string value to ensure the idempotency of the operation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [MaxLength(128)]
    public string? IdempotencyKey { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

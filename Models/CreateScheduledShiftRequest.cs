using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:Labor-CreateScheduledShift">CreateScheduledShift</see> request.
/// </summary>
public record CreateScheduledShiftRequest
{
    /// <summary>
    /// A unique identifier for the <c>CreateScheduledShift</c> request, used to ensure the
    /// <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">idempotency</see>
    /// of the operation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [MaxLength(128)]
    public string? IdempotencyKey { get; init; }

    /// <summary>
    /// Represents a specific time slot in a work schedule. This object is used to manage the
    /// lifecycle of a scheduled shift from the draft to published state. A scheduled shift contains
    /// the latest draft shift details and current published shift details.
    /// </summary>
    [JsonPropertyName("scheduled_shift")]
    public required ScheduledShift ScheduledShift { get; init; }
}

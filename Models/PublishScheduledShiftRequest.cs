using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:Labor-PublishScheduledShift">PublishScheduledShift</see> request.
/// </summary>
public record PublishScheduledShiftRequest
{
    /// <summary>
    /// A unique identifier for the <c>PublishScheduledShift</c> request, used to ensure the
    /// <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">idempotency</see>
    /// of the operation.
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// The current version of the scheduled shift, used to enable <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/optimistic-concurrency">optimistic concurrency</see>
    /// control. If the provided version doesn't match the server version, the request fails.
    /// If omitted, Square executes a blind write, potentially overwriting data from another publish request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    /// <summary>
    /// Indicates whether Square sends an email notification to team members
    /// when a scheduled shift is published and which team members receive the notification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheduled_shift_notification_audience")]
    public ScheduledShiftNotificationAudience? ScheduledShiftNotificationAudience { get; init; }
}

using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:Labor-BulkPublishScheduledShifts">BulkPublishScheduledShifts</see> request.
/// </summary>
public record BulkPublishScheduledShiftsRequest
{
    /// <summary>
    /// A map of 1 to 100 key-value pairs that represent individual publish requests.
    /// <para>
    /// - Each key is the ID of a scheduled shift you want to publish.
    /// - Each value is a <c>BulkPublishScheduledShiftsData</c> object that contains the
    /// <c>version</c> field or is an empty object.
    /// </para>
    /// </summary>
    [JsonPropertyName("scheduled_shifts")]
    public required IReadOnlyDictionary<string, BulkPublishScheduledShiftsData> ScheduledShifts { get; init; }

    /// <summary>
    /// Indicates whether Square sends an email notification to team members
    /// when a scheduled shift is published and which team members receive the notification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheduled_shift_notification_audience")]
    public ScheduledShiftNotificationAudience? ScheduledShiftNotificationAudience { get; init; }
}

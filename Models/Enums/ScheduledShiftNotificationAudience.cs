using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates whether Square sends an email notification to team members
/// when a scheduled shift is published and which team members receive the notification.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScheduledShiftNotificationAudience>))]
public sealed record ScheduledShiftNotificationAudience : StringEnum<ScheduledShiftNotificationAudience>
{
    private ScheduledShiftNotificationAudience(string value) : base(value)
    {
    }

    /// <summary>
    /// Notify all active team members. Note that republishing an unchanged
    /// shift with this setting resends the notification.
    /// </summary>
    public static readonly ScheduledShiftNotificationAudience All = new("ALL");

    /// <summary>
    /// Notify the team member assigned to the shift. If the shift assignment
    /// changes, notify both the newly assigned and previously assigned team members.
    /// </summary>
    public static readonly ScheduledShiftNotificationAudience Affected = new("AFFECTED");

    /// <summary>
    /// Do not send a notification.
    /// </summary>
    public static readonly ScheduledShiftNotificationAudience None = new("NONE");

    public static ScheduledShiftNotificationAudience FromValue(string value) => FromValueCore(value);
}

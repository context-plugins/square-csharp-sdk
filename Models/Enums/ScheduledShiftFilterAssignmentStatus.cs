using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Defines valid values for the <c>assignment_status</c> filter in a
/// <see href="api-endpoint:Labor-SearchScheduledShifts">SearchScheduledShifts</see> request.
/// Assignment status is based on the <c>draft_shift_details.team_member_id</c> and
/// <c>published_shift_details.team_member_id</c> fields of the scheduled shift.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScheduledShiftFilterAssignmentStatus>))]
public sealed record ScheduledShiftFilterAssignmentStatus : StringEnum<ScheduledShiftFilterAssignmentStatus>
{
    private ScheduledShiftFilterAssignmentStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The shift is assigned to a team member.
    /// </summary>
    public static readonly ScheduledShiftFilterAssignmentStatus Assigned = new("ASSIGNED");

    /// <summary>
    /// The shift isn't assigned to a team member.
    /// </summary>
    public static readonly ScheduledShiftFilterAssignmentStatus Unassigned = new("UNASSIGNED");

    public static ScheduledShiftFilterAssignmentStatus FromValue(string value) => FromValueCore(value);
}

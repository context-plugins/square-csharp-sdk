using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Defines filter criteria for a <see href="api-endpoint:Labor-SearchScheduledShifts">SearchScheduledShifts</see>
/// request. Multiple filters in a query are combined as an <c>AND</c> operation.
/// </summary>
public record ScheduledShiftFilter
{
    /// <summary>
    /// Return shifts for the specified locations. When omitted, shifts for all
    /// locations are returned. If needed, call <see href="api-endpoint:Locations-ListLocations">ListLocations</see>
    /// to get location IDs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_ids")]
    public IReadOnlyList<string?>? LocationIds { get; init; }

    /// <summary>
    /// Represents a generic time range. The start and end values are
    /// represented in RFC 3339 format. Time ranges are customized to be
    /// inclusive or exclusive based on the needs of a particular endpoint.
    /// Refer to the relevant endpoint-specific documentation to determine
    /// how time ranges are handled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start")]
    public TimeRange? Start { get; init; }

    /// <summary>
    /// Represents a generic time range. The start and end values are
    /// represented in RFC 3339 format. Time ranges are customized to be
    /// inclusive or exclusive based on the needs of a particular endpoint.
    /// Refer to the relevant endpoint-specific documentation to determine
    /// how time ranges are handled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end")]
    public TimeRange? End { get; init; }

    /// <summary>
    /// A <c>ScheduledShift</c> search query filter parameter that sets a range of days that
    /// a <c>Shift</c> must start or end in before passing the filter condition.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("workday")]
    public ScheduledShiftWorkday? Workday { get; init; }

    /// <summary>
    /// Return shifts assigned to specified team members. If needed, call
    /// <see href="api-endpoint:Team-SearchTeamMembers">SearchTeamMembers</see> to get team member IDs.
    /// <para>
    /// To return only the shifts assigned to the specified team members, include the
    /// <c>assignment_status</c> filter in the query. Otherwise, all unassigned shifts are
    /// returned along with shifts assigned to the specified team members.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member_ids")]
    public IReadOnlyList<string?>? TeamMemberIds { get; init; }

    /// <summary>
    /// Defines valid values for the <c>assignment_status</c> filter in a
    /// <see href="api-endpoint:Labor-SearchScheduledShifts">SearchScheduledShifts</see> request.
    /// Assignment status is based on the <c>draft_shift_details.team_member_id</c> and
    /// <c>published_shift_details.team_member_id</c> fields of the scheduled shift.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assignment_status")]
    public ScheduledShiftFilterAssignmentStatus? AssignmentStatus { get; init; }

    /// <summary>
    /// Return shifts based on the draft or published status of the shift.
    /// A shift is published if the <c>published_shift_details</c> field is present.
    /// <para>
    /// Note that shifts with <c>draft_shift_details.is_deleted</c> set to <c>true</c> are ignored
    /// with the <c>DRAFT</c> filter.
    /// See <see href="#type-scheduledshiftfilterscheduledshiftstatus">ScheduledShiftFilterScheduledShiftStatus</see> for possible values
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheduled_shift_statuses")]
    public IReadOnlyList<ScheduledShiftFilterScheduledShiftStatus?>? ScheduledShiftStatuses { get; init; }
}

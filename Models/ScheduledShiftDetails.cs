using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents shift details for draft and published versions of a <see href="entity:ScheduledShift">scheduled shift</see>,
/// such as job ID, team member assignment, and start and end times.
/// </summary>
public record ScheduledShiftDetails
{
    /// <summary>
    /// The ID of the <see href="entity:TeamMember">team member</see> scheduled for the shift.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member_id")]
    [MaxLength(255)]
    public string? TeamMemberId { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:Location">location</see> the shift is scheduled for.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    [MaxLength(255)]
    public string? LocationId { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:Job">job</see> the shift is scheduled for.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("job_id")]
    public string? JobId { get; init; }

    /// <summary>
    /// The start time of the shift, in RFC 3339 format in the time zone &amp;plus;
    /// offset of the shift location specified in <c>location_id</c>. Precision up to the minute
    /// is respected; seconds are truncated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_at")]
    public string? StartAt { get; init; }

    /// <summary>
    /// The end time for the shift, in RFC 3339 format in the time zone &amp;plus;
    /// offset of the shift location specified in <c>location_id</c>. Precision up to the minute
    /// is respected; seconds are truncated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_at")]
    public string? EndAt { get; init; }

    /// <summary>
    /// Optional notes for the shift.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notes")]
    [MaxLength(1000)]
    public string? Notes { get; init; }

    /// <summary>
    /// Indicates whether the draft shift version is deleted. If set to <c>true</c> when the shift
    /// is published, the entire scheduled shift (including the published shift) is deleted and
    /// cannot be accessed using any endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_deleted")]
    public bool? IsDeleted { get; init; }

    /// <summary>
    /// The time zone of the shift location, calculated based on the <c>location_id</c>. This field
    /// is provided for convenience.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timezone")]
    public string? Timezone { get; init; }
}

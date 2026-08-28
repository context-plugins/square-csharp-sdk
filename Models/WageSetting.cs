using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents information about the overtime exemption status, job assignments, and compensation
/// for a <see href="entity:TeamMember">team member</see>.
/// </summary>
public record WageSetting
{
    /// <summary>
    /// The ID of the team member associated with the wage setting.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member_id")]
    public string? TeamMemberId { get; init; }

    /// <summary>
    /// <b>Required</b> The ordered list of jobs that the team member is assigned to.
    /// The first job assignment is considered the team member's primary job.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("job_assignments")]
    public IReadOnlyList<JobAssignment?>? JobAssignments { get; init; }

    /// <summary>
    /// Whether the team member is exempt from the overtime rules of the seller's country.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_overtime_exempt")]
    public bool? IsOvertimeExempt { get; init; }

    /// <summary>
    /// <b>Read only</b> Used for resolving concurrency issues. The request fails if the version
    /// provided does not match the server version at the time of the request. If not provided,
    /// Square executes a blind write, potentially overwriting data from another write. For more information,
    /// see <see href="https://developer.squareup.com/docs/working-with-apis/optimistic-concurrency">optimistic concurrency</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    /// <summary>
    /// The timestamp when the wage setting was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The timestamp when the wage setting was last updated, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a bulk update request for <c>TeamMember</c> objects.
/// </summary>
public record BulkUpdateTeamMembersRequest
{
    /// <summary>
    /// The data used to update the <c>TeamMember</c> objects. Each key is the <c>team_member_id</c> that maps to the <c>UpdateTeamMemberRequest</c>.
    /// The maximum number of update objects is 25.
    /// <para>
    /// For each team member, include the fields to add, change, or clear. Fields can be cleared using a null value.
    /// To update <c>wage_setting.job_assignments</c>, you must provide the complete list of job assignments. If needed,
    /// call <see href="api-endpoint:Team-ListJobs">ListJobs</see> to get the required <c>job_id</c> values.
    /// </para>
    /// </summary>
    [JsonPropertyName("team_members")]
    public required IReadOnlyDictionary<string, UpdateTeamMemberRequest> TeamMembers { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a bulk create request for <c>TeamMember</c> objects.
/// </summary>
public record BulkCreateTeamMembersRequest
{
    /// <summary>
    /// The data used to create the <c>TeamMember</c> objects. Each key is the <c>idempotency_key</c> that maps to the <c>CreateTeamMemberRequest</c>.
    /// The maximum number of create objects is 25.
    /// <para>
    /// If you include a team member's <c>wage_setting</c>, you must provide <c>job_id</c> for each job assignment. To get job IDs,
    /// call <see href="api-endpoint:Team-ListJobs">ListJobs</see>.
    /// </para>
    /// </summary>
    [JsonPropertyName("team_members")]
    public required IReadOnlyDictionary<string, CreateTeamMemberRequest> TeamMembers { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

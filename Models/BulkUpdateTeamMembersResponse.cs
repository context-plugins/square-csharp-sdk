using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a response from a bulk update request containing the updated <c>TeamMember</c> objects or error messages.
/// </summary>
public record BulkUpdateTeamMembersResponse
{
    /// <summary>
    /// The successfully updated <c>TeamMember</c> objects. Each key is the <c>team_member_id</c> that maps to the <c>UpdateTeamMemberRequest</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_members")]
    public IReadOnlyDictionary<string, UpdateTeamMemberResponse>? TeamMembers { get; init; }

    /// <summary>
    /// The errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}

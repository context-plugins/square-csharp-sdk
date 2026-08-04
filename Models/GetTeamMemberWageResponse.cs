using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// A response to a request to get a <c>TeamMemberWage</c>. The response contains
/// the requested <c>TeamMemberWage</c> objects and might contain a set of <c>Error</c> objects if
/// the request resulted in errors.
/// </summary>
public record GetTeamMemberWageResponse
{
    /// <summary>
    /// Job and wage information for a <see href="entity:TeamMember">team member</see>.
    /// This convenience object provides details needed to specify the <c>wage</c>
    /// field for a <see href="entity:Timecard">timecard</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member_wage")]
    public TeamMemberWage? TeamMemberWage { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}

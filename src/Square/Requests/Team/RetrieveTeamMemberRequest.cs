namespace Square.Requests.Team;

/// <summary>
/// The inputs of the RetrieveTeamMember operation.
/// </summary>
public sealed record RetrieveTeamMemberRequest
{
    /// <summary>
    /// The ID of the team member to retrieve.
    /// </summary>
    public required string TeamMemberId { get; init; }
}

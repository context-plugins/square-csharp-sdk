using Square.Models;

namespace Square.Requests.Team;

/// <summary>
/// The inputs of the UpdateTeamMember operation.
/// </summary>
public sealed record UpdateTeamMemberOperationRequest
{
    /// <summary>
    /// The ID of the team member to update.
    /// </summary>
    public required string TeamMemberId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateTeamMemberRequest Body { get; init; }
}

using Square.Models;

namespace Square.Requests.Team;

/// <summary>
/// The inputs of the CreateTeamMember operation.
/// </summary>
public sealed record CreateTeamMemberOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateTeamMemberRequest Body { get; init; }
}

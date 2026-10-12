using Square.Models;

namespace Square.Requests.Team;

/// <summary>
/// The inputs of the SearchTeamMembers operation.
/// </summary>
public sealed record SearchTeamMembersOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required SearchTeamMembersRequest Body { get; init; }
}

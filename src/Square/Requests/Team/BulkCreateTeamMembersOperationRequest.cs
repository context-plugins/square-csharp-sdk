using Square.Models;

namespace Square.Requests.Team;

/// <summary>
/// The inputs of the BulkCreateTeamMembers operation.
/// </summary>
public sealed record BulkCreateTeamMembersOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required BulkCreateTeamMembersRequest Body { get; init; }
}

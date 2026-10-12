using Square.Models;

namespace Square.Requests.Team;

/// <summary>
/// The inputs of the BulkUpdateTeamMembers operation.
/// </summary>
public sealed record BulkUpdateTeamMembersOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required BulkUpdateTeamMembersRequest Body { get; init; }
}

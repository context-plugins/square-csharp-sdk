using Square.Models;

namespace Square.Requests.Team;

/// <summary>
/// The inputs of the UpdateWageSetting operation.
/// </summary>
public sealed record UpdateWageSettingOperationRequest
{
    /// <summary>
    /// The ID of the team member for which to update the <c>WageSetting</c> object.
    /// </summary>
    public required string TeamMemberId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateWageSettingRequest Body { get; init; }
}

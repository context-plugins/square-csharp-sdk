namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the GetTeamMemberWage operation.
/// </summary>
public sealed record GetTeamMemberWageRequest
{
    /// <summary>
    /// The UUID for the <c>TeamMemberWage</c> being retrieved.
    /// </summary>
    public required string Id { get; init; }
}

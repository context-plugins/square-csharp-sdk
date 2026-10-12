namespace Square.Requests.Team;

/// <summary>
/// The inputs of the RetrieveWageSetting operation.
/// </summary>
public sealed record RetrieveWageSettingRequest
{
    /// <summary>
    /// The ID of the team member for which to retrieve the wage setting.
    /// </summary>
    public required string TeamMemberId { get; init; }
}

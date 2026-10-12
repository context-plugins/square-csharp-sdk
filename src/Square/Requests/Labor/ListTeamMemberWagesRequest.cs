namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the ListTeamMemberWages operation.
/// </summary>
public sealed record ListTeamMemberWagesRequest
{
    /// <summary>
    /// Filter the returned wages to only those that are associated with the
    /// specified team member.
    /// </summary>
    public string? TeamMemberId { get; init; }

    /// <summary>
    /// The maximum number of <c>TeamMemberWage</c> results to return per page. The number can range between
    /// 1 and 200. The default is 200.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// A pointer to the next page of <c>EmployeeWage</c> results to fetch.
    /// </summary>
    public string? Cursor { get; init; }
}

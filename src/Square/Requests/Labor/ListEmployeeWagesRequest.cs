namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the ListEmployeeWages operation.
/// </summary>
public sealed record ListEmployeeWagesRequest
{
    /// <summary>
    /// Filter the returned wages to only those that are associated with the specified employee.
    /// </summary>
    public string? EmployeeId { get; init; }

    /// <summary>
    /// The maximum number of <c>EmployeeWage</c> results to return per page. The number can range between
    /// 1 and 200. The default is 200.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// A pointer to the next page of <c>EmployeeWage</c> results to fetch.
    /// </summary>
    public string? Cursor { get; init; }
}

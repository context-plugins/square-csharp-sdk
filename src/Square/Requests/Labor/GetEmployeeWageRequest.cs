namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the GetEmployeeWage operation.
/// </summary>
public sealed record GetEmployeeWageRequest
{
    /// <summary>
    /// The UUID for the <c>EmployeeWage</c> being retrieved.
    /// </summary>
    public required string Id { get; init; }
}

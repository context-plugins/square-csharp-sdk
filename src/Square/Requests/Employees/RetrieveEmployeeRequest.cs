namespace Square.Requests.Employees;

/// <summary>
/// The inputs of the RetrieveEmployee operation.
/// </summary>
public sealed record RetrieveEmployeeRequest
{
    /// <summary>
    /// UUID for the employee that was requested.
    /// </summary>
    public required string Id { get; init; }
}

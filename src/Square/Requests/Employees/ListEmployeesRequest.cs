using Square.Models.Enums;

namespace Square.Requests.Employees;

/// <summary>
/// The inputs of the ListEmployees operation.
/// </summary>
public sealed record ListEmployeesRequest
{
    public string? LocationId { get; init; }

    /// <summary>
    /// Specifies the EmployeeStatus to filter the employee by.
    /// </summary>
    public EmployeeStatus? Status { get; init; }

    /// <summary>
    /// The number of employees to be returned on each page.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The token required to retrieve the specified page of results.
    /// </summary>
    public string? Cursor { get; init; }
}

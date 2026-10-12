using Square.Models;

namespace Square.Requests.Customers;

/// <summary>
/// The inputs of the SearchCustomers operation.
/// </summary>
public sealed record SearchCustomersOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required SearchCustomersRequest Body { get; init; }
}

using Square.Models;

namespace Square.Requests.Customers;

/// <summary>
/// The inputs of the BulkDeleteCustomers operation.
/// </summary>
public sealed record BulkDeleteCustomersOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required BulkDeleteCustomersRequest Body { get; init; }
}

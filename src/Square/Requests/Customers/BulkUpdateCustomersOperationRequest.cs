using Square.Models;

namespace Square.Requests.Customers;

/// <summary>
/// The inputs of the BulkUpdateCustomers operation.
/// </summary>
public sealed record BulkUpdateCustomersOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required BulkUpdateCustomersRequest Body { get; init; }
}

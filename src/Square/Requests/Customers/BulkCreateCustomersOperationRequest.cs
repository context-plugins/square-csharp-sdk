using Square.Models;

namespace Square.Requests.Customers;

/// <summary>
/// The inputs of the BulkCreateCustomers operation.
/// </summary>
public sealed record BulkCreateCustomersOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required BulkCreateCustomersRequest Body { get; init; }
}

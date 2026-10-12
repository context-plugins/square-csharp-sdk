using Square.Models;

namespace Square.Requests.Customers;

/// <summary>
/// The inputs of the UpdateCustomer operation.
/// </summary>
public sealed record UpdateCustomerOperationRequest
{
    /// <summary>
    /// The ID of the customer to update.
    /// </summary>
    public required string CustomerId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateCustomerRequest Body { get; init; }
}

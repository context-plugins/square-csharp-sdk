using Square.Models;

namespace Square.Requests.Customers;

/// <summary>
/// The inputs of the CreateCustomerCard operation.
/// </summary>
public sealed record CreateCustomerCardOperationRequest
{
    /// <summary>
    /// The Square ID of the customer profile the card is linked to.
    /// </summary>
    public required string CustomerId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateCustomerCardRequest Body { get; init; }
}

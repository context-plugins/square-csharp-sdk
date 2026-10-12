namespace Square.Requests.Customers;

/// <summary>
/// The inputs of the DeleteCustomerCard operation.
/// </summary>
public sealed record DeleteCustomerCardRequest
{
    /// <summary>
    /// The ID of the customer that the card on file belongs to.
    /// </summary>
    public required string CustomerId { get; init; }

    /// <summary>
    /// The ID of the card on file to delete.
    /// </summary>
    public required string CardId { get; init; }
}

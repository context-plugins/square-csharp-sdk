namespace Square.Requests.Customers;

/// <summary>
/// The inputs of the RemoveGroupFromCustomer operation.
/// </summary>
public sealed record RemoveGroupFromCustomerRequest
{
    /// <summary>
    /// The ID of the customer to remove from the group.
    /// </summary>
    public required string CustomerId { get; init; }

    /// <summary>
    /// The ID of the customer group to remove the customer from.
    /// </summary>
    public required string GroupId { get; init; }
}

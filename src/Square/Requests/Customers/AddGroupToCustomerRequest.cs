namespace Square.Requests.Customers;

/// <summary>
/// The inputs of the AddGroupToCustomer operation.
/// </summary>
public sealed record AddGroupToCustomerRequest
{
    /// <summary>
    /// The ID of the customer to add to a group.
    /// </summary>
    public required string CustomerId { get; init; }

    /// <summary>
    /// The ID of the customer group to add the customer to.
    /// </summary>
    public required string GroupId { get; init; }
}

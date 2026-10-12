namespace Square.Requests.Customers;

/// <summary>
/// The inputs of the RetrieveCustomer operation.
/// </summary>
public sealed record RetrieveCustomerRequest
{
    /// <summary>
    /// The ID of the customer to retrieve.
    /// </summary>
    public required string CustomerId { get; init; }
}

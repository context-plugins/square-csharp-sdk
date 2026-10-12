namespace Square.Requests.Customers;

/// <summary>
/// The inputs of the DeleteCustomer operation.
/// </summary>
public sealed record DeleteCustomerRequest
{
    /// <summary>
    /// The ID of the customer to delete.
    /// </summary>
    public required string CustomerId { get; init; }

    /// <summary>
    /// The current version of the customer profile.
    /// <para>
    /// As a best practice, you should include this parameter to enable <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/optimistic-concurrency">optimistic concurrency</see> control.  For more information, see <see href="https://developer.squareup.com/docs/customers-api/use-the-api/keep-records#delete-customer-profile">Delete a customer profile</see>.
    /// </para>
    /// </summary>
    public long? Version { get; init; }
}

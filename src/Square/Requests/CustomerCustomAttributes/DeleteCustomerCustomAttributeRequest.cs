namespace Square.Requests.CustomerCustomAttributes;

/// <summary>
/// The inputs of the DeleteCustomerCustomAttribute operation.
/// </summary>
public sealed record DeleteCustomerCustomAttributeRequest
{
    /// <summary>
    /// The ID of the target <see href="entity:Customer">customer profile</see>.
    /// </summary>
    public required string CustomerId { get; init; }

    /// <summary>
    /// The key of the custom attribute to delete. This key must match the <c>key</c> of a custom
    /// attribute definition in the Square seller account. If the requesting application is not the
    /// definition owner, you must use the qualified key.
    /// </summary>
    public required string Key { get; init; }
}

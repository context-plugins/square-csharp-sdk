namespace Square.Requests.CustomerCustomAttributes;

/// <summary>
/// The inputs of the DeleteCustomerCustomAttributeDefinition operation.
/// </summary>
public sealed record DeleteCustomerCustomAttributeDefinitionRequest
{
    /// <summary>
    /// The key of the custom attribute definition to delete.
    /// </summary>
    public required string Key { get; init; }
}

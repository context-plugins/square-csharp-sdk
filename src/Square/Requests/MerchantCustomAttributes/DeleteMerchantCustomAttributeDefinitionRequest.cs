namespace Square.Requests.MerchantCustomAttributes;

/// <summary>
/// The inputs of the DeleteMerchantCustomAttributeDefinition operation.
/// </summary>
public sealed record DeleteMerchantCustomAttributeDefinitionRequest
{
    /// <summary>
    /// The key of the custom attribute definition to delete.
    /// </summary>
    public required string Key { get; init; }
}

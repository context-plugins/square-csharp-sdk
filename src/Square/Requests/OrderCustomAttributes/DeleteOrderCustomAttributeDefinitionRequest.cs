namespace Square.Requests.OrderCustomAttributes;

/// <summary>
/// The inputs of the DeleteOrderCustomAttributeDefinition operation.
/// </summary>
public sealed record DeleteOrderCustomAttributeDefinitionRequest
{
    /// <summary>
    /// The key of the custom attribute definition to delete.
    /// </summary>
    public required string Key { get; init; }
}

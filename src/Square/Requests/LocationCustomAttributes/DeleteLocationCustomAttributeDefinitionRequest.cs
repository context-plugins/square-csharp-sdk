namespace Square.Requests.LocationCustomAttributes;

/// <summary>
/// The inputs of the DeleteLocationCustomAttributeDefinition operation.
/// </summary>
public sealed record DeleteLocationCustomAttributeDefinitionRequest
{
    /// <summary>
    /// The key of the custom attribute definition to delete.
    /// </summary>
    public required string Key { get; init; }
}

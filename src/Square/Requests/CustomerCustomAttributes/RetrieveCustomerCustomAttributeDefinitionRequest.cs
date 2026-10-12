namespace Square.Requests.CustomerCustomAttributes;

/// <summary>
/// The inputs of the RetrieveCustomerCustomAttributeDefinition operation.
/// </summary>
public sealed record RetrieveCustomerCustomAttributeDefinitionRequest
{
    /// <summary>
    /// The key of the custom attribute definition to retrieve. If the requesting application
    /// is not the definition owner, you must use the qualified key.
    /// </summary>
    public required string Key { get; init; }

    /// <summary>
    /// The current version of the custom attribute definition, which is used for strongly consistent
    /// reads to guarantee that you receive the most up-to-date data. When included in the request,
    /// Square returns the specified version or a higher version if one exists. If the specified version
    /// is higher than the current version, Square returns a <c>BAD_REQUEST</c> error.
    /// </summary>
    public int? Version { get; init; }
}

namespace Square.Requests.OrderCustomAttributes;

/// <summary>
/// The inputs of the RetrieveOrderCustomAttributeDefinition operation.
/// </summary>
public sealed record RetrieveOrderCustomAttributeDefinitionRequest
{
    /// <summary>
    /// The key of the custom attribute definition to retrieve.
    /// </summary>
    public required string Key { get; init; }

    /// <summary>
    /// To enable <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/optimistic-concurrency">optimistic concurrency</see>
    /// control, include this optional field and specify the current version of the custom attribute.
    /// </summary>
    public int? Version { get; init; }
}

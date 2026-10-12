namespace Square.Requests.OrderCustomAttributes;

/// <summary>
/// The inputs of the RetrieveOrderCustomAttribute operation.
/// </summary>
public sealed record RetrieveOrderCustomAttributeRequest
{
    /// <summary>
    /// The ID of the target <see href="entity:Order">order</see>.
    /// </summary>
    public required string OrderId { get; init; }

    /// <summary>
    /// The key of the custom attribute to retrieve.  This key must match the key of an
    /// existing custom attribute definition.
    /// </summary>
    public required string CustomAttributeKey { get; init; }

    /// <summary>
    /// To enable <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/optimistic-concurrency">optimistic concurrency</see>
    /// control, include this optional field and specify the current version of the custom attribute.
    /// </summary>
    public int? Version { get; init; }

    /// <summary>
    /// Indicates whether to return the <see href="entity:CustomAttributeDefinition">custom attribute definition</see> in the <c>definition</c> field of each
    /// custom attribute. Set this parameter to <c>true</c> to get the name and description of each custom attribute,
    /// information about the data type, or other definition details. The default value is <c>false</c>.
    /// </summary>
    public bool WithDefinition { get; init; } = false;
}

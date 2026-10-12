namespace Square.Requests.MerchantCustomAttributes;

/// <summary>
/// The inputs of the RetrieveMerchantCustomAttribute operation.
/// </summary>
public sealed record RetrieveMerchantCustomAttributeRequest
{
    /// <summary>
    /// The ID of the target <see href="entity:Merchant">merchant</see>.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The key of the custom attribute to retrieve. This key must match the <c>key</c> of a custom
    /// attribute definition in the Square seller account. If the requesting application is not the
    /// definition owner, you must use the qualified key.
    /// </summary>
    public required string Key { get; init; }

    /// <summary>
    /// Indicates whether to return the <see href="entity:CustomAttributeDefinition">custom attribute definition</see> in the <c>definition</c> field of
    /// the custom attribute. Set this parameter to <c>true</c> to get the name and description of the custom
    /// attribute, information about the data type, or other definition details. The default value is <c>false</c>.
    /// </summary>
    public bool WithDefinition { get; init; } = false;

    /// <summary>
    /// The current version of the custom attribute, which is used for strongly consistent reads to
    /// guarantee that you receive the most up-to-date data. When included in the request, Square
    /// returns the specified version or a higher version if one exists. If the specified version is
    /// higher than the current version, Square returns a <c>BAD_REQUEST</c> error.
    /// </summary>
    public int? Version { get; init; }
}

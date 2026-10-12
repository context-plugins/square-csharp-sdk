using Square.Models.Enums;

namespace Square.Requests.OrderCustomAttributes;

/// <summary>
/// The inputs of the ListOrderCustomAttributes operation.
/// </summary>
public sealed record ListOrderCustomAttributesRequest
{
    /// <summary>
    /// The ID of the target <see href="entity:Order">order</see>.
    /// </summary>
    public required string OrderId { get; init; }

    /// <summary>
    /// Requests that all of the custom attributes be returned, or only those that are read-only or read-write.
    /// </summary>
    public VisibilityFilter? VisibilityFilter { get; init; }

    /// <summary>
    /// The cursor returned in the paged response from the previous call to this endpoint.
    /// Provide this cursor to retrieve the next page of results for your original request.
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// The maximum number of results to return in a single paged response. This limit is advisory.
    /// The response might contain more or fewer results. The minimum value is 1 and the maximum value is 100.
    /// The default value is 20.
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Indicates whether to return the <see href="entity:CustomAttributeDefinition">custom attribute definition</see> in the <c>definition</c> field of each
    /// custom attribute. Set this parameter to <c>true</c> to get the name and description of each custom attribute,
    /// information about the data type, or other definition details. The default value is <c>false</c>.
    /// </summary>
    public bool WithDefinitions { get; init; } = false;
}

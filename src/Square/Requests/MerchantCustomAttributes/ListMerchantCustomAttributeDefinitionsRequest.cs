using Square.Models.Enums;

namespace Square.Requests.MerchantCustomAttributes;

/// <summary>
/// The inputs of the ListMerchantCustomAttributeDefinitions operation.
/// </summary>
public sealed record ListMerchantCustomAttributeDefinitionsRequest
{
    /// <summary>
    /// Filters the <c>CustomAttributeDefinition</c> results by their <c>visibility</c> values.
    /// </summary>
    public VisibilityFilter? VisibilityFilter { get; init; }

    /// <summary>
    /// The maximum number of results to return in a single paged response. This limit is advisory.
    /// The response might contain more or fewer results. The minimum value is 1 and the maximum value is 100.
    /// The default value is 20. For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The cursor returned in the paged response from the previous call to this endpoint.
    /// Provide this cursor to retrieve the next page of results for your original request.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    public string? Cursor { get; init; }
}

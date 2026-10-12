namespace Square.Requests.CustomerGroups;

/// <summary>
/// The inputs of the ListCustomerGroups operation.
/// </summary>
public sealed record ListCustomerGroupsRequest
{
    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this cursor to retrieve the next set of results for your original query.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// The maximum number of results to return in a single page. This limit is advisory. The response might contain more or fewer results.
    /// If the limit is less than 1 or greater than 50, Square returns a <c>400 VALUE_TOO_LOW</c> or <c>400 VALUE_TOO_HIGH</c> error. The default value is 50.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    public int? Limit { get; init; }
}

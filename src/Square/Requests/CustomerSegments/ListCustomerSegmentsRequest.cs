namespace Square.Requests.CustomerSegments;

/// <summary>
/// The inputs of the ListCustomerSegments operation.
/// </summary>
public sealed record ListCustomerSegmentsRequest
{
    /// <summary>
    /// A pagination cursor returned by previous calls to <c>ListCustomerSegments</c>.
    /// This cursor is used to retrieve the next set of query results.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// The maximum number of results to return in a single page. This limit is advisory. The response might contain more or fewer results.
    /// If the specified limit is less than 1 or greater than 50, Square returns a <c>400 VALUE_TOO_LOW</c> or <c>400 VALUE_TOO_HIGH</c> error. The default value is 50.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    public int? Limit { get; init; }
}

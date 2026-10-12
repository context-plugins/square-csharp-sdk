namespace Square.Requests.CheckoutApi;

/// <summary>
/// The inputs of the ListPaymentLinks operation.
/// </summary>
public sealed record ListPaymentLinksRequest
{
    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this cursor to retrieve the next set of results for the original query.
    /// If a cursor is not provided, the endpoint returns the first page of the results.
    /// For more  information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// A limit on the number of results to return per page. The limit is advisory and
    /// the implementation might return more or less results. If the supplied limit is negative, zero, or
    /// greater than the maximum limit of 1000, it is ignored.
    /// <para>
    /// Default value: <c>100</c>
    /// </para>
    /// </summary>
    public int? Limit { get; init; }
}

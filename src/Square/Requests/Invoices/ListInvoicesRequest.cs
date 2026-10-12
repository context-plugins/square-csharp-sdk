namespace Square.Requests.Invoices;

/// <summary>
/// The inputs of the ListInvoices operation.
/// </summary>
public sealed record ListInvoicesRequest
{
    /// <summary>
    /// The ID of the location for which to list invoices.
    /// </summary>
    public required string LocationId { get; init; }

    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this cursor to retrieve the next set of results for your original query.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// The maximum number of invoices to return (200 is the maximum <c>limit</c>).
    /// If not provided, the server uses a default limit of 100 invoices.
    /// </summary>
    public int? Limit { get; init; }
}

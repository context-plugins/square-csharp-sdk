using Square.Models.Enums;

namespace Square.Requests.Transactions;

/// <summary>
/// The inputs of the ListTransactions operation.
/// </summary>
public sealed record ListTransactionsRequest
{
    /// <summary>
    /// The ID of the location to list transactions for.
    /// </summary>
    public required string LocationId { get; init; }

    /// <summary>
    /// The beginning of the requested reporting period, in RFC 3339 format.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">Date ranges</see> for details on date inclusivity/exclusivity.
    /// </para>
    /// <para>
    /// Default value: The current time minus one year.
    /// </para>
    /// </summary>
    public string? BeginTime { get; init; }

    /// <summary>
    /// The end of the requested reporting period, in RFC 3339 format.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">Date ranges</see> for details on date inclusivity/exclusivity.
    /// </para>
    /// <para>
    /// Default value: The current time.
    /// </para>
    /// </summary>
    public string? EndTime { get; init; }

    /// <summary>
    /// The order in which results are listed in the response (<c>ASC</c> for
    /// oldest first, <c>DESC</c> for newest first).
    /// <para>
    /// Default value: <c>DESC</c>
    /// </para>
    /// </summary>
    public SortOrder? SortOrder { get; init; }

    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this to retrieve the next set of results for your original query.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Paginating results</see> for more information.
    /// </para>
    /// </summary>
    public string? Cursor { get; init; }
}

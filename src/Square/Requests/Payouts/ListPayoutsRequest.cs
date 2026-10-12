using Square.Models.Enums;

namespace Square.Requests.Payouts;

/// <summary>
/// The inputs of the ListPayouts operation.
/// </summary>
public sealed record ListPayoutsRequest
{
    /// <summary>
    /// The ID of the location for which to list the payouts.
    /// By default, payouts are returned for the default (main) location associated with the seller.
    /// </summary>
    public string? LocationId { get; init; }

    /// <summary>
    /// If provided, only payouts with the given status are returned.
    /// </summary>
    public PayoutStatus? Status { get; init; }

    /// <summary>
    /// The timestamp for the beginning of the payout creation time, in RFC 3339 format.
    /// Inclusive. Default: The current time minus one year.
    /// </summary>
    public string? BeginTime { get; init; }

    /// <summary>
    /// The timestamp for the end of the payout creation time, in RFC 3339 format.
    /// Default: The current time.
    /// </summary>
    public string? EndTime { get; init; }

    /// <summary>
    /// The order in which payouts are listed.
    /// </summary>
    public SortOrder? SortOrder { get; init; }

    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this cursor to retrieve the next set of results for the original query.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// If request parameters change between requests, subsequent results may contain duplicates or missing records.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// The maximum number of results to be returned in a single page.
    /// It is possible to receive fewer results than the specified limit on a given page.
    /// The default value of 100 is also the maximum allowed value. If the provided value is
    /// greater than 100, it is ignored and the default value is used instead.
    /// Default: <c>100</c>
    /// </summary>
    public int? Limit { get; init; }
}

using Square.Models.Enums;

namespace Square.Requests.Refunds;

/// <summary>
/// The inputs of the ListPaymentRefunds operation.
/// </summary>
public sealed record ListPaymentRefundsRequest
{
    /// <summary>
    /// Indicates the start of the time range to retrieve each <c>PaymentRefund</c> for, in RFC 3339
    /// format.  The range is determined using the <c>created_at</c> field for each <c>PaymentRefund</c>.
    /// <para>
    /// Default: The current time minus one year.
    /// </para>
    /// </summary>
    public string? BeginTime { get; init; }

    /// <summary>
    /// Indicates the end of the time range to retrieve each <c>PaymentRefund</c> for, in RFC 3339
    /// format.  The range is determined using the <c>created_at</c> field for each <c>PaymentRefund</c>.
    /// <para>
    /// Default: The current time.
    /// </para>
    /// </summary>
    public string? EndTime { get; init; }

    /// <summary>
    /// The order in which results are listed by <c>PaymentRefund.created_at</c>:
    /// - <c>ASC</c> - Oldest to newest.
    /// - <c>DESC</c> - Newest to oldest (default).
    /// </summary>
    public string? SortOrder { get; init; }

    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this cursor to retrieve the next set of results for the original query.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// Limit results to the location supplied. By default, results are returned
    /// for all locations associated with the seller.
    /// </summary>
    public string? LocationId { get; init; }

    /// <summary>
    /// If provided, only refunds with the given status are returned.
    /// For a list of refund status values, see <see href="entity:PaymentRefund">PaymentRefund</see>.
    /// <para>
    /// Default: If omitted, refunds are returned regardless of their status.
    /// </para>
    /// </summary>
    public string? Status { get; init; }

    /// <summary>
    /// If provided, only returns refunds whose payments have the indicated source type.
    /// Current values include <c>CARD</c>, <c>BANK_ACCOUNT</c>, <c>WALLET</c>, <c>CASH</c>, and <c>EXTERNAL</c>.
    /// For information about these payment source types, see
    /// <see href="https://developer.squareup.com/docs/payments-api/take-payments">Take Payments</see>.
    /// <para>
    /// Default: If omitted, refunds are returned regardless of the source type.
    /// </para>
    /// </summary>
    public string? SourceType { get; init; }

    /// <summary>
    /// The maximum number of results to be returned in a single page.
    /// <para>
    /// It is possible to receive fewer results than the specified limit on a given page.
    /// </para>
    /// <para>
    /// If the supplied value is greater than 100, no more than 100 results are returned.
    /// </para>
    /// <para>
    /// Default: 100
    /// </para>
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Indicates the start of the time range to retrieve each <c>PaymentRefund</c> for, in RFC 3339
    /// format.  The range is determined using the <c>updated_at</c> field for each <c>PaymentRefund</c>.
    /// <para>
    /// Default: If omitted, the time range starts at <c>begin_time</c>.
    /// </para>
    /// </summary>
    public string? UpdatedAtBeginTime { get; init; }

    /// <summary>
    /// Indicates the end of the time range to retrieve each <c>PaymentRefund</c> for, in RFC 3339
    /// format.  The range is determined using the <c>updated_at</c> field for each <c>PaymentRefund</c>.
    /// <para>
    /// Default: The current time.
    /// </para>
    /// </summary>
    public string? UpdatedAtEndTime { get; init; }

    /// <summary>
    /// The field used to sort results by. The default is <c>CREATED_AT</c>.
    /// </summary>
    public ListPaymentRefundsRequestSortField? SortField { get; init; }
}

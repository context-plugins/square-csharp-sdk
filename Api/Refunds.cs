using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Square.Core;
using Square.Core.ErrorResponse;
using Square.Core.Exceptions;
using Square.Core.Models;
using Square.Core.Request;
using Square.Core.Response;
using Square.Models;
using Square.Models.Enums;

namespace Square.Api;

public sealed class Refunds
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Refunds(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// GetPaymentRefund
    /// </summary>
    /// <param name="refundId">The unique ID for the desired <c>PaymentRefund</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetPaymentRefundResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a specific refund using the <c>refund_id</c>.
    /// </remarks>
    public Task<GetPaymentRefundResponse> GetPaymentRefund(string refundId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/refunds/{refund_id}"),
            [new TemplateParam("refund_id", refundId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetPaymentRefundResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListPaymentRefunds
    /// </summary>
    /// <param name="beginTime">Indicates the start of the time range to retrieve each <c>PaymentRefund</c> for, in RFC 3339  format.  The range is determined using the <c>created_at</c> field for each <c>PaymentRefund</c>.   Default: The current time minus one year.</param>
    /// <param name="endTime">Indicates the end of the time range to retrieve each <c>PaymentRefund</c> for, in RFC 3339  format.  The range is determined using the <c>created_at</c> field for each <c>PaymentRefund</c>.  Default: The current time.</param>
    /// <param name="sortOrder">The order in which results are listed by <c>PaymentRefund.created_at</c>: - <c>ASC</c> - Oldest to newest. - <c>DESC</c> - Newest to oldest (default).</param>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this cursor to retrieve the next set of results for the original query.  For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.</param>
    /// <param name="locationId">Limit results to the location supplied. By default, results are returned for all locations associated with the seller.</param>
    /// <param name="status">If provided, only refunds with the given status are returned. For a list of refund status values, see <see href="entity:PaymentRefund">PaymentRefund</see>.  Default: If omitted, refunds are returned regardless of their status.</param>
    /// <param name="sourceType">If provided, only returns refunds whose payments have the indicated source type. Current values include <c>CARD</c>, <c>BANK_ACCOUNT</c>, <c>WALLET</c>, <c>CASH</c>, and <c>EXTERNAL</c>. For information about these payment source types, see <see href="https://developer.squareup.com/docs/payments-api/take-payments">Take Payments</see>.  Default: If omitted, refunds are returned regardless of the source type.</param>
    /// <param name="limit">The maximum number of results to be returned in a single page.  It is possible to receive fewer results than the specified limit on a given page.  If the supplied value is greater than 100, no more than 100 results are returned.  Default: 100</param>
    /// <param name="updatedAtBeginTime">Indicates the start of the time range to retrieve each <c>PaymentRefund</c> for, in RFC 3339 format.  The range is determined using the <c>updated_at</c> field for each <c>PaymentRefund</c>.  Default: If omitted, the time range starts at <c>begin_time</c>.</param>
    /// <param name="updatedAtEndTime">Indicates the end of the time range to retrieve each <c>PaymentRefund</c> for, in RFC 3339 format.  The range is determined using the <c>updated_at</c> field for each <c>PaymentRefund</c>.  Default: The current time.</param>
    /// <param name="sortField">The field used to sort results by. The default is <c>CREATED_AT</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListPaymentRefundsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a list of refunds for the account making the request.
    /// <para>
    /// Results are eventually consistent, and new refunds or changes to refunds might take several
    /// seconds to appear.
    /// </para>
    /// <para>
    /// The maximum results per page is 100.
    /// </para>
    /// </remarks>
    public Task<ListPaymentRefundsResponse> ListPaymentRefunds(string? beginTime,
        string? endTime,
        string? sortOrder,
        string? cursor,
        string? locationId,
        string? status,
        string? sourceType,
        int? limit,
        string? updatedAtBeginTime,
        string? updatedAtEndTime,
        ListPaymentRefundsRequestSortField? sortField,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/refunds"),
            [],
            [new Param("begin_time", beginTime),
                new Param("end_time", endTime),
                new Param("sort_order", sortOrder),
                new Param("cursor", cursor),
                new Param("location_id", locationId),
                new Param("status", status),
                new Param("source_type", sourceType),
                new Param("limit", limit),
                new Param("updated_at_begin_time", updatedAtBeginTime),
                new Param("updated_at_end_time", updatedAtEndTime),
                new Param("sort_field", sortField)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListPaymentRefundsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RefundPayment
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RefundPaymentResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Refunds a payment. You can refund the entire payment amount or a
    /// portion of it. You can use this endpoint to refund a card payment or record a
    /// refund of a cash or external payment. For more information, see
    /// <see href="https://developer.squareup.com/docs/payments-api/refund-payments">Refund Payment</see>.
    /// </remarks>
    public Task<RefundPaymentResponse> RefundPayment(RefundPaymentRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/refunds"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RefundPaymentResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);
}

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
using Square.Requests.Refunds;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetPaymentRefundResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a specific refund using the <c>refund_id</c>.
    /// </remarks>
    public Task<GetPaymentRefundResponse> GetPaymentRefund(GetPaymentRefundRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/refunds/{refund_id}"),
            [new TemplateParam("refund_id", request.RefundId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetPaymentRefundResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListPaymentRefunds
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListPaymentRefundsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<ListPaymentRefundsResponse> ListPaymentRefunds(ListPaymentRefundsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/refunds"),
            [],
            [
                new Param("begin_time", request.BeginTime),
                new Param("end_time", request.EndTime),
                new Param("sort_order", request.SortOrder),
                new Param("cursor", request.Cursor),
                new Param("location_id", request.LocationId),
                new Param("status", request.Status),
                new Param("source_type", request.SourceType),
                new Param("limit", request.Limit),
                new Param("updated_at_begin_time", request.UpdatedAtBeginTime),
                new Param("updated_at_end_time", request.UpdatedAtEndTime),
                new Param("sort_field", request.SortField),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListPaymentRefundsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RefundPayment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RefundPaymentResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Refunds a payment. You can refund the entire payment amount or a
    /// portion of it. You can use this endpoint to refund a card payment or record a
    /// refund of a cash or external payment. For more information, see
    /// <see href="https://developer.squareup.com/docs/payments-api/refund-payments">Refund Payment</see>.
    /// </remarks>
    public Task<RefundPaymentResponse> RefundPayment(RefundPaymentOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/refunds"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<RefundPaymentResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}

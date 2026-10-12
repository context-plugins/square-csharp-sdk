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
using Square.Requests.Payments;

namespace Square.Api;

public sealed class Payments
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Payments(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CancelPayment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CancelPaymentResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels (voids) a payment. You can use this endpoint to cancel a payment with
    /// the APPROVED <c>status</c>.
    /// </remarks>
    public Task<CancelPaymentResponse> CancelPayment(CancelPaymentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/payments/{payment_id}/cancel"),
            [new TemplateParam("payment_id", request.PaymentId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CancelPaymentResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CancelPaymentByIdempotencyKey
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CancelPaymentByIdempotencyKeyResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels (voids) a payment identified by the idempotency key that is specified in the
    /// request.
    /// <para>
    /// Use this method when the status of a <c>CreatePayment</c> request is unknown (for example, after you send a
    /// <c>CreatePayment</c> request, a network error occurs and you do not get a response). In this case, you can
    /// direct Square to cancel the payment using this endpoint. In the request, you provide the same
    /// idempotency key that you provided in your <c>CreatePayment</c> request that you want to cancel. After
    /// canceling the payment, you can submit your <c>CreatePayment</c> request again.
    /// </para>
    /// <para>
    /// Note that if no payment with the specified idempotency key is found, no action is taken and the endpoint
    /// returns successfully.
    /// </para>
    /// </remarks>
    public Task<CancelPaymentByIdempotencyKeyResponse> CancelPaymentByIdempotencyKey(CancelPaymentByIdempotencyKeyOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/payments/cancel"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CancelPaymentByIdempotencyKeyResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CompletePayment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CompletePaymentResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Completes (captures) a payment.
    /// By default, payments are set to complete immediately after they are created.
    /// <para>
    /// You can use this endpoint to complete a payment with the APPROVED <c>status</c>.
    /// </para>
    /// </remarks>
    public Task<CompletePaymentResponse> CompletePayment(CompletePaymentOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/payments/{payment_id}/complete"),
            [new TemplateParam("payment_id", request.PaymentId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CompletePaymentResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CreatePayment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreatePaymentResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a payment using the provided source. You can use this endpoint
    /// to charge a card (credit/debit card or
    /// Square gift card) or record a payment that the seller received outside of Square
    /// (cash payment from a buyer or a payment that an external entity
    /// processed on behalf of the seller).
    /// <para>
    /// The endpoint creates a
    /// <c>Payment</c> object and returns it in the response.
    /// </para>
    /// </remarks>
    public Task<CreatePaymentResponse> CreatePayment(CreatePaymentOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/payments"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreatePaymentResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// GetPayment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetPaymentResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves details for a specific payment.
    /// </remarks>
    public Task<GetPaymentResponse> GetPayment(GetPaymentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/payments/{payment_id}"),
            [new TemplateParam("payment_id", request.PaymentId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetPaymentResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListPayments
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListPaymentsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a list of payments taken by the account making the request.
    /// <para>
    /// Results are eventually consistent, and new payments or changes to payments might take several
    /// seconds to appear.
    /// </para>
    /// <para>
    /// The maximum results per page is 100.
    /// </para>
    /// </remarks>
    public Task<ListPaymentsResponse> ListPayments(ListPaymentsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/payments"),
            [],
            [
                new Param("begin_time", request.BeginTime),
                new Param("end_time", request.EndTime),
                new Param("sort_order", request.SortOrder),
                new Param("cursor", request.Cursor),
                new Param("location_id", request.LocationId),
                new Param("total", request.Total),
                new Param("last_4", request.Last4),
                new Param("card_brand", request.CardBrand),
                new Param("limit", request.Limit),
                new Param("is_offline_payment", request.IsOfflinePayment),
                new Param("offline_begin_time", request.OfflineBeginTime),
                new Param("offline_end_time", request.OfflineEndTime),
                new Param("updated_at_begin_time", request.UpdatedAtBeginTime),
                new Param("updated_at_end_time", request.UpdatedAtEndTime),
                new Param("sort_field", request.SortField),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListPaymentsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpdatePayment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdatePaymentResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a payment with the APPROVED status.
    /// You can update the <c>amount_money</c> and <c>tip_money</c> using this endpoint.
    /// </remarks>
    public Task<UpdatePaymentResponse> UpdatePayment(UpdatePaymentOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/payments/{payment_id}"),
            [new TemplateParam("payment_id", request.PaymentId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdatePaymentResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}

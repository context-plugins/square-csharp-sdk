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
using Square.Requests.Transactions;

namespace Square.Api;

public sealed class Transactions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Transactions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CaptureTransaction
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CaptureTransactionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Captures a transaction that was created with the <see href="api-endpoint:Transactions-Charge">Charge</see>
    /// endpoint with a <c>delay_capture</c> value of <c>true</c>.
    /// <para>
    ///
    /// See <see href="https://developer.squareup.com/docs/payments/transactions/overview#delayed-capture">Delayed capture transactions</see>
    /// for more information.
    /// </para>
    /// </remarks>
    public Task<CaptureTransactionResponse> CaptureTransaction(CaptureTransactionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/locations/{location_id}/transactions/{transaction_id}/capture"),
            [
                new TemplateParam("location_id", request.LocationId),
                new TemplateParam("transaction_id", request.TransactionId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CaptureTransactionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListTransactions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListTransactionsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists transactions for a particular location.
    /// <para>
    /// Transactions include payment information from sales and exchanges and refund
    /// information from returns and exchanges.
    /// </para>
    /// <para>
    /// Max results per <see href="https://developer.squareup.com/docs/working-with-apis/pagination">page</see>: 50
    /// </para>
    /// </remarks>
    public Task<ListTransactionsResponse> ListTransactions(ListTransactionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/locations/{location_id}/transactions"),
            [new TemplateParam("location_id", request.LocationId)],
            [
                new Param("begin_time", request.BeginTime),
                new Param("end_time", request.EndTime),
                new Param("sort_order", request.SortOrder),
                new Param("cursor", request.Cursor),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListTransactionsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveTransaction
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveTransactionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves details for a single transaction.
    /// </remarks>
    public Task<RetrieveTransactionResponse> RetrieveTransaction(RetrieveTransactionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/locations/{location_id}/transactions/{transaction_id}"),
            [
                new TemplateParam("location_id", request.LocationId),
                new TemplateParam("transaction_id", request.TransactionId),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveTransactionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// VoidTransaction
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VoidTransactionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels a transaction that was created with the <see href="api-endpoint:Transactions-Charge">Charge</see>
    /// endpoint with a <c>delay_capture</c> value of <c>true</c>.
    /// <para>
    ///
    /// See <see href="https://developer.squareup.com/docs/payments/transactions/overview#delayed-capture">Delayed capture transactions</see>
    /// for more information.
    /// </para>
    /// </remarks>
    public Task<VoidTransactionResponse> VoidTransaction(VoidTransactionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/locations/{location_id}/transactions/{transaction_id}/void"),
            [
                new TemplateParam("location_id", request.LocationId),
                new TemplateParam("transaction_id", request.TransactionId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<VoidTransactionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}

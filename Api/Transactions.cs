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
    /// <param name="locationId"></param>
    /// <param name="transactionId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CaptureTransactionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Captures a transaction that was created with the <see href="api-endpoint:Transactions-Charge">Charge</see>
    /// endpoint with a <c>delay_capture</c> value of <c>true</c>.
    /// <para>
    ///
    /// See <see href="https://developer.squareup.com/docs/payments/transactions/overview#delayed-capture">Delayed capture transactions</see>
    /// for more information.
    /// </para>
    /// </remarks>
    public Task<CaptureTransactionResponse> CaptureTransaction(string locationId,
        string transactionId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/locations/{location_id}/transactions/{transaction_id}/capture"),
            [new TemplateParam("location_id", locationId), new TemplateParam("transaction_id", transactionId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CaptureTransactionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListTransactions
    /// </summary>
    /// <param name="locationId">The ID of the location to list transactions for.</param>
    /// <param name="beginTime">The beginning of the requested reporting period, in RFC 3339 format.  See <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">Date ranges</see> for details on date inclusivity/exclusivity.  Default value: The current time minus one year.</param>
    /// <param name="endTime">The end of the requested reporting period, in RFC 3339 format.  See <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">Date ranges</see> for details on date inclusivity/exclusivity.  Default value: The current time.</param>
    /// <param name="sortOrder">The order in which results are listed in the response (<c>ASC</c> for oldest first, <c>DESC</c> for newest first).  Default value: <c>DESC</c></param>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query.  See <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Paginating results</see> for more information.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListTransactionsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<ListTransactionsResponse> ListTransactions(string locationId,
        string? beginTime,
        string? endTime,
        SortOrder? sortOrder,
        string? cursor,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/locations/{location_id}/transactions"),
            [new TemplateParam("location_id", locationId)],
            [new Param("begin_time", beginTime),
                new Param("end_time", endTime),
                new Param("sort_order", sortOrder),
                new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListTransactionsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveTransaction
    /// </summary>
    /// <param name="locationId">The ID of the transaction's associated location.</param>
    /// <param name="transactionId">The ID of the transaction to retrieve.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveTransactionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves details for a single transaction.
    /// </remarks>
    public Task<RetrieveTransactionResponse> RetrieveTransaction(string locationId,
        string transactionId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/locations/{location_id}/transactions/{transaction_id}"),
            [new TemplateParam("location_id", locationId), new TemplateParam("transaction_id", transactionId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveTransactionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// VoidTransaction
    /// </summary>
    /// <param name="locationId"></param>
    /// <param name="transactionId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VoidTransactionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels a transaction that was created with the <see href="api-endpoint:Transactions-Charge">Charge</see>
    /// endpoint with a <c>delay_capture</c> value of <c>true</c>.
    /// <para>
    ///
    /// See <see href="https://developer.squareup.com/docs/payments/transactions/overview#delayed-capture">Delayed capture transactions</see>
    /// for more information.
    /// </para>
    /// </remarks>
    public Task<VoidTransactionResponse> VoidTransaction(string locationId,
        string transactionId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/locations/{location_id}/transactions/{transaction_id}/void"),
            [new TemplateParam("location_id", locationId), new TemplateParam("transaction_id", transactionId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<VoidTransactionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);
}

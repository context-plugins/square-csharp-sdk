using System;
using System.Collections.Generic;
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

public sealed class V1Transactions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal V1Transactions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// V1ListOrders
    /// </summary>
    /// <param name="locationId">The ID of the location to list online store orders for.</param>
    /// <param name="order">The order in which payments are listed in the response.</param>
    /// <param name="limit">The maximum number of payments to return in a single response. This value cannot exceed 200.</param>
    /// <param name="batchToken">A pagination cursor to retrieve the next set of results for your original query to the endpoint.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="V1Order"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides summary information for a merchant's online store orders.
    /// </remarks>
    public Task<IReadOnlyList<V1Order>> V1ListOrders(string locationId,
        SortOrder? order,
        int? limit,
        string? batchToken,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/{location_id}/orders"),
            [new TemplateParam("location_id", locationId)],
            [new Param("order", order), new Param("limit", limit), new Param("batch_token", batchToken)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<V1Order>>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// V1RetrieveOrder
    /// </summary>
    /// <param name="locationId">The ID of the order's associated location.</param>
    /// <param name="orderId">The order's Square-issued ID. You obtain this value from Order objects returned by the List Orders endpoint</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1Order"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides comprehensive information for a single online store order, including the order's history.
    /// </remarks>
    public Task<V1Order> V1RetrieveOrder(string locationId,
        string orderId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/{location_id}/orders/{order_id}"),
            [new TemplateParam("location_id", locationId), new TemplateParam("order_id", orderId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1Order>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// V1UpdateOrder
    /// </summary>
    /// <param name="locationId">The ID of the order's associated location.</param>
    /// <param name="orderId">The order's Square-issued ID. You obtain this value from Order objects returned by the List Orders endpoint</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1Order"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the details of an online store order. Every update you perform on an order corresponds to one of three actions:
    /// </remarks>
    public Task<V1Order> V1UpdateOrder(string locationId,
        string orderId,
        V1UpdateOrderRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/{location_id}/orders/{order_id}"),
            [new TemplateParam("location_id", locationId), new TemplateParam("order_id", orderId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<V1Order>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);
}

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
using Square.Requests.TransferOrderApi;

namespace Square.Api;

public sealed class TransferOrderApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TransferOrderApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CancelTransferOrder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CancelTransferOrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels a transfer order in <see href="entity:TransferOrderStatus">STARTED</see> or
    /// <see href="entity:TransferOrderStatus">PARTIALLY_RECEIVED</see> status. Any unreceived quantities will no
    /// longer be receivable and will be immediately returned to the source <see href="entity:Location">Location</see>'s inventory.
    /// <para>
    /// Common reasons for cancellation:
    /// - Items no longer needed at destination
    /// - Source location needs the inventory
    /// - Order created in error
    /// </para>
    /// <para>
    /// Creates a <see href="webhook:transfer_order.updated">transfer_order.updated</see> webhook event.
    /// </para>
    /// </remarks>
    public Task<CancelTransferOrderResponse> CancelTransferOrder(CancelTransferOrderOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/transfer-orders/{transfer_order_id}/cancel"),
            [new TemplateParam("transfer_order_id", request.TransferOrderId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CancelTransferOrderResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CreateTransferOrder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateTransferOrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new transfer order in <see href="entity:TransferOrderStatus">DRAFT</see> status. A transfer order represents the intent
    /// to move <see href="entity:CatalogItemVariation">CatalogItemVariation</see>s from one <see href="entity:Location">Location</see> to another.
    /// The source and destination locations must be different and must belong to your Square account.
    /// <para>
    /// In <see href="entity:TransferOrderStatus">DRAFT</see> status, you can:
    /// - Add or remove items
    /// - Modify quantities
    /// - Update shipping information
    /// - Delete the entire order via <see href="api-endpoint:TransferOrders-DeleteTransferOrder">DeleteTransferOrder</see>
    /// </para>
    /// <para>
    /// The request requires source_location_id and destination_location_id.
    /// Inventory levels are not affected until the order is started via
    /// <see href="api-endpoint:TransferOrders-StartTransferOrder">StartTransferOrder</see>.
    /// </para>
    /// <para>
    /// Common integration points:
    /// - Sync with warehouse management systems
    /// - Automate regular stock transfers
    /// - Initialize transfers from inventory optimization systems
    /// </para>
    /// <para>
    /// Creates a <see href="webhook:transfer_order.created">transfer_order.created</see> webhook event.
    /// </para>
    /// </remarks>
    public Task<CreateTransferOrderResponse> CreateTransferOrder(CreateTransferOrderOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/transfer-orders"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateTransferOrderResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeleteTransferOrder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteTransferOrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a transfer order in <see href="entity:TransferOrderStatus">DRAFT</see> status.
    /// Only draft orders can be deleted. Once an order is started via
    /// <see href="api-endpoint:TransferOrders-StartTransferOrder">StartTransferOrder</see>, it can no longer be deleted.
    /// <para>
    /// Creates a <see href="webhook:transfer_order.deleted">transfer_order.deleted</see> webhook event.
    /// </para>
    /// </remarks>
    public Task<DeleteTransferOrderResponse> DeleteTransferOrder(DeleteTransferOrderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/transfer-orders/{transfer_order_id}"),
            [new TemplateParam("transfer_order_id", request.TransferOrderId)],
            [new Param("version", request.Version)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteTransferOrderResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ReceiveTransferOrder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ReceiveTransferOrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Records receipt of <see href="entity:CatalogItemVariation">CatalogItemVariation</see>s for a transfer order.
    /// This endpoint supports partial receiving - you can receive items in multiple batches.
    /// <para>
    /// For each line item, you can specify:
    /// - Quantity received in good condition (added to destination inventory with <see href="entity:InventoryState">InventoryState</see> of IN_STOCK)
    /// - Quantity damaged during transit/handling (added to destination inventory with <see href="entity:InventoryState">InventoryState</see> of WASTE)
    /// - Quantity canceled (returned to source location's inventory)
    /// </para>
    /// <para>
    /// The order must be in <see href="entity:TransferOrderStatus">STARTED</see> or <see href="entity:TransferOrderStatus">PARTIALLY_RECEIVED</see> status.
    /// Received quantities are added to the destination <see href="entity:Location">Location</see>'s inventory according to their condition.
    /// Canceled quantities are immediately returned to the source <see href="entity:Location">Location</see>'s inventory.
    /// </para>
    /// <para>
    /// When all items are either received, damaged, or canceled, the order moves to
    /// <see href="entity:TransferOrderStatus">COMPLETED</see> status.
    /// </para>
    /// <para>
    /// Creates a <see href="webhook:transfer_order.updated">transfer_order.updated</see> webhook event.
    /// </para>
    /// </remarks>
    public Task<ReceiveTransferOrderResponse> ReceiveTransferOrder(ReceiveTransferOrderOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/transfer-orders/{transfer_order_id}/receive"),
            [new TemplateParam("transfer_order_id", request.TransferOrderId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ReceiveTransferOrderResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveTransferOrder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveTransferOrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a specific <see href="entity:TransferOrder">TransferOrder</see> by ID. Returns the complete
    /// order details including:
    /// <list type="bullet">
    ///   <item><description>Basic information (status, dates, notes)</description></item>
    ///   <item><description>Line items with ordered and received quantities</description></item>
    ///   <item><description>Source and destination <see href="entity:Location">Location</see>s</description></item>
    ///   <item><description>Tracking information (if available)</description></item>
    /// </list>
    /// </remarks>
    public Task<RetrieveTransferOrderResponse> RetrieveTransferOrder(RetrieveTransferOrderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/transfer-orders/{transfer_order_id}"),
            [new TemplateParam("transfer_order_id", request.TransferOrderId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveTransferOrderResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// SearchTransferOrders
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchTransferOrdersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches for transfer orders using filters. Returns a paginated list of matching
    /// <see href="entity:TransferOrder">TransferOrder</see>s sorted by creation date.
    /// <para>
    /// Common search scenarios:
    /// - Find orders for a source <see href="entity:Location">Location</see>
    /// - Find orders for a destination <see href="entity:Location">Location</see>
    /// - Find orders in a particular <see href="entity:TransferOrderStatus">TransferOrderStatus</see>
    /// </para>
    /// </remarks>
    public Task<SearchTransferOrdersResponse> SearchTransferOrders(SearchTransferOrdersOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/transfer-orders/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SearchTransferOrdersResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// StartTransferOrder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StartTransferOrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes a <see href="entity:TransferOrderStatus">DRAFT</see> transfer order to <see href="entity:TransferOrderStatus">STARTED</see> status.
    /// This decrements inventory at the source <see href="entity:Location">Location</see> and marks it as in-transit.
    /// <para>
    /// The order must be in <see href="entity:TransferOrderStatus">DRAFT</see> status and have all required fields populated.
    /// Once started, the order can no longer be deleted, but it can be canceled via
    /// <see href="api-endpoint:TransferOrders-CancelTransferOrder">CancelTransferOrder</see>.
    /// </para>
    /// <para>
    /// Creates a <see href="webhook:transfer_order.updated">transfer_order.updated</see> webhook event.
    /// </para>
    /// </remarks>
    public Task<StartTransferOrderResponse> StartTransferOrder(StartTransferOrderOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/transfer-orders/{transfer_order_id}/start"),
            [new TemplateParam("transfer_order_id", request.TransferOrderId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<StartTransferOrderResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpdateTransferOrder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateTransferOrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates an existing transfer order. This endpoint supports sparse updates,
    /// allowing you to modify specific fields without affecting others.
    /// <para>
    /// Creates a <see href="webhook:transfer_order.updated">transfer_order.updated</see> webhook event.
    /// </para>
    /// </remarks>
    public Task<UpdateTransferOrderResponse> UpdateTransferOrder(UpdateTransferOrderOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/transfer-orders/{transfer_order_id}"),
            [new TemplateParam("transfer_order_id", request.TransferOrderId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateTransferOrderResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}

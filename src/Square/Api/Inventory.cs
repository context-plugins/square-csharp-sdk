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
using Square.Requests.Inventory;

namespace Square.Api;

public sealed class Inventory
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Inventory(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// BatchChangeInventory
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchChangeInventoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Applies adjustments and counts to the provided item quantities.
    /// <para>
    /// On success: returns the current calculated counts for all objects
    /// referenced in the request.
    /// On failure: returns a list of related errors.
    /// </para>
    /// </remarks>
    public Task<BatchChangeInventoryResponse> BatchChangeInventory(BatchChangeInventoryOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/inventory/changes/batch-create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BatchChangeInventoryResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// BatchRetrieveInventoryChanges
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchRetrieveInventoryChangesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns historical physical counts and adjustments based on the
    /// provided filter criteria.
    /// <para>
    /// Results are paginated and sorted in ascending order according their
    /// <c>occurred_at</c> timestamp (oldest first).
    /// </para>
    /// <para>
    /// BatchRetrieveInventoryChanges is a catch-all query endpoint for queries
    /// that cannot be handled by other, simpler endpoints.
    /// </para>
    /// </remarks>
    public Task<BatchRetrieveInventoryChangesResponse> BatchRetrieveInventoryChanges(BatchRetrieveInventoryChangesOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/inventory/changes/batch-retrieve"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BatchRetrieveInventoryChangesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// BatchRetrieveInventoryCounts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchRetrieveInventoryCountsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns current counts for the provided
    /// <see href="entity:CatalogObject">CatalogObject</see>s at the requested
    /// <see href="entity:Location">Location</see>s.
    /// <para>
    /// Results are paginated and sorted in descending order according to their
    /// <c>calculated_at</c> timestamp (newest first).
    /// </para>
    /// <para>
    /// When <c>updated_after</c> is specified, only counts that have changed since that
    /// time (based on the server timestamp for the most recent change) are
    /// returned. This allows clients to perform a "sync" operation, for example
    /// in response to receiving a Webhook notification.
    /// </para>
    /// </remarks>
    public Task<BatchRetrieveInventoryCountsResponse> BatchRetrieveInventoryCounts(BatchRetrieveInventoryCountsOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/inventory/counts/batch-retrieve"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BatchRetrieveInventoryCountsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CreateInventoryAdjustmentReason
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateInventoryAdjustmentReasonResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a custom inventory adjustment reason.
    /// </remarks>
    public Task<CreateInventoryAdjustmentReasonResponse> CreateInventoryAdjustmentReason(CreateInventoryAdjustmentReasonOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/inventory/adjustment-reasons/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateInventoryAdjustmentReasonResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeleteInventoryAdjustmentReason
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteInventoryAdjustmentReasonResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Soft deletes a custom inventory adjustment reason.
    /// </remarks>
    public Task<DeleteInventoryAdjustmentReasonResponse> DeleteInventoryAdjustmentReason(DeleteInventoryAdjustmentReasonOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/inventory/adjustment-reasons/delete"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeleteInventoryAdjustmentReasonResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeprecatedBatchChangeInventory
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchChangeInventoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deprecated version of <see href="api-endpoint:Inventory-BatchChangeInventory">BatchChangeInventory</see> after the endpoint URL
    /// is updated to conform to the standard convention.
    /// </remarks>
    public Task<BatchChangeInventoryResponse> DeprecatedBatchChangeInventory(DeprecatedBatchChangeInventoryRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/inventory/batch-change"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BatchChangeInventoryResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeprecatedBatchRetrieveInventoryChanges
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchRetrieveInventoryChangesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deprecated version of <see href="api-endpoint:Inventory-BatchRetrieveInventoryChanges">BatchRetrieveInventoryChanges</see> after the endpoint URL
    /// is updated to conform to the standard convention.
    /// </remarks>
    public Task<BatchRetrieveInventoryChangesResponse> DeprecatedBatchRetrieveInventoryChanges(DeprecatedBatchRetrieveInventoryChangesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/inventory/batch-retrieve-changes"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BatchRetrieveInventoryChangesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeprecatedBatchRetrieveInventoryCounts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchRetrieveInventoryCountsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deprecated version of <see href="api-endpoint:Inventory-BatchRetrieveInventoryCounts">BatchRetrieveInventoryCounts</see> after the endpoint URL
    /// is updated to conform to the standard convention.
    /// </remarks>
    public Task<BatchRetrieveInventoryCountsResponse> DeprecatedBatchRetrieveInventoryCounts(DeprecatedBatchRetrieveInventoryCountsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/inventory/batch-retrieve-counts"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BatchRetrieveInventoryCountsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeprecatedRetrieveInventoryAdjustment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveInventoryAdjustmentResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deprecated version of <see href="api-endpoint:Inventory-RetrieveInventoryAdjustment">RetrieveInventoryAdjustment</see> after the endpoint URL
    /// is updated to conform to the standard convention.
    /// </remarks>
    public Task<RetrieveInventoryAdjustmentResponse> DeprecatedRetrieveInventoryAdjustment(DeprecatedRetrieveInventoryAdjustmentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/inventory/adjustment/{adjustment_id}"),
            [new TemplateParam("adjustment_id", request.AdjustmentId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveInventoryAdjustmentResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeprecatedRetrieveInventoryPhysicalCount
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveInventoryPhysicalCountResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deprecated version of <see href="api-endpoint:Inventory-RetrieveInventoryPhysicalCount">RetrieveInventoryPhysicalCount</see> after the endpoint URL
    /// is updated to conform to the standard convention.
    /// </remarks>
    public Task<RetrieveInventoryPhysicalCountResponse> DeprecatedRetrieveInventoryPhysicalCount(DeprecatedRetrieveInventoryPhysicalCountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/inventory/physical-count/{physical_count_id}"),
            [new TemplateParam("physical_count_id", request.PhysicalCountId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveInventoryPhysicalCountResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListInventoryAdjustmentReasons
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListInventoryAdjustmentReasonsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the standard and custom inventory adjustment reasons available
    /// to the seller.
    /// </remarks>
    public Task<ListInventoryAdjustmentReasonsResponse> ListInventoryAdjustmentReasons(ListInventoryAdjustmentReasonsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/inventory/adjustment-reasons"),
            [],
            [
                new Param("include_deleted", request.IncludeDeleted),
                new Param("include_system_codes", request.IncludeSystemCodes),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListInventoryAdjustmentReasonsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RestoreInventoryAdjustmentReason
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RestoreInventoryAdjustmentReasonResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Restores a soft-deleted custom inventory adjustment reason.
    /// </remarks>
    public Task<RestoreInventoryAdjustmentReasonResponse> RestoreInventoryAdjustmentReason(RestoreInventoryAdjustmentReasonOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/inventory/adjustment-reasons/restore"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<RestoreInventoryAdjustmentReasonResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveInventoryAdjustment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveInventoryAdjustmentResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the <see href="entity:InventoryAdjustment">InventoryAdjustment</see> object
    /// with the provided <c>adjustment_id</c>.
    /// </remarks>
    public Task<RetrieveInventoryAdjustmentResponse> RetrieveInventoryAdjustment(RetrieveInventoryAdjustmentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/inventory/adjustments/{adjustment_id}"),
            [new TemplateParam("adjustment_id", request.AdjustmentId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveInventoryAdjustmentResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveInventoryAdjustmentReason
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveInventoryAdjustmentReasonResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the inventory adjustment reason identified by the provided
    /// <c>reason_id</c>. Deleted custom reasons can be retrieved by ID.
    /// </remarks>
    public Task<RetrieveInventoryAdjustmentReasonResponse> RetrieveInventoryAdjustmentReason(RetrieveInventoryAdjustmentReasonOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/inventory/adjustment-reasons/retrieve"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<RetrieveInventoryAdjustmentReasonResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveInventoryChanges
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveInventoryChangesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a set of physical counts and inventory adjustments for the
    /// provided <see href="entity:CatalogObject">CatalogObject</see> at the requested
    /// <see href="entity:Location">Location</see>s.
    /// <para>
    /// You can achieve the same result by calling <see href="api-endpoint:Inventory-BatchRetrieveInventoryChanges">BatchRetrieveInventoryChanges</see>
    /// and having the <c>catalog_object_ids</c> list contain a single element of the <c>CatalogObject</c> ID.
    /// </para>
    /// <para>
    /// Results are paginated and sorted in descending order according to their
    /// <c>occurred_at</c> timestamp (newest first).
    /// </para>
    /// <para>
    /// There are no limits on how far back the caller can page. This endpoint can be
    /// used to display recent changes for a specific item. For more
    /// sophisticated queries, use a batch endpoint.
    /// </para>
    /// </remarks>
    public Task<RetrieveInventoryChangesResponse> RetrieveInventoryChanges(RetrieveInventoryChangesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/inventory/{catalog_object_id}/changes"),
            [new TemplateParam("catalog_object_id", request.CatalogObjectId)],
            [new Param("location_ids", request.LocationIds), new Param("cursor", request.Cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveInventoryChangesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveInventoryCount
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveInventoryCountResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the current calculated stock count for a given
    /// <see href="entity:CatalogObject">CatalogObject</see> at a given set of
    /// <see href="entity:Location">Location</see>s. Responses are paginated and unsorted.
    /// For more sophisticated queries, use a batch endpoint.
    /// </remarks>
    public Task<RetrieveInventoryCountResponse> RetrieveInventoryCount(RetrieveInventoryCountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/inventory/{catalog_object_id}"),
            [new TemplateParam("catalog_object_id", request.CatalogObjectId)],
            [new Param("location_ids", request.LocationIds), new Param("cursor", request.Cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveInventoryCountResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveInventoryPhysicalCount
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveInventoryPhysicalCountResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the <see href="entity:InventoryPhysicalCount">InventoryPhysicalCount</see>
    /// object with the provided <c>physical_count_id</c>.
    /// </remarks>
    public Task<RetrieveInventoryPhysicalCountResponse> RetrieveInventoryPhysicalCount(RetrieveInventoryPhysicalCountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/inventory/physical-counts/{physical_count_id}"),
            [new TemplateParam("physical_count_id", request.PhysicalCountId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveInventoryPhysicalCountResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpdateInventoryAdjustment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateInventoryAdjustmentResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Applies an update to the provided adjustment.
    /// <para>
    /// On success: returns the newly updated adjustment.
    /// On failure: returns a list of related errors.
    /// </para>
    /// </remarks>
    public Task<UpdateInventoryAdjustmentResponse> UpdateInventoryAdjustment(UpdateInventoryAdjustmentOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/inventory/adjustments/update"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateInventoryAdjustmentResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpdateInventoryAdjustmentReason
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateInventoryAdjustmentReasonResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a custom inventory adjustment reason.
    /// </remarks>
    public Task<UpdateInventoryAdjustmentReasonResponse> UpdateInventoryAdjustmentReason(UpdateInventoryAdjustmentReasonOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/inventory/adjustment-reasons/update"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateInventoryAdjustmentReasonResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}

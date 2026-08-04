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

namespace Square.Api;

public sealed class Catalog
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Catalog(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// BatchDeleteCatalogObjects
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchDeleteCatalogObjectsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a set of <see href="entity:CatalogItem">CatalogItem</see>s based on the
    /// provided list of target IDs and returns a set of successfully deleted IDs in
    /// the response. Deletion is a cascading event such that all children of the
    /// targeted object are also deleted. For example, deleting a CatalogItem will
    /// also delete all of its <see href="entity:CatalogItemVariation">CatalogItemVariation</see>
    /// children.
    /// <para>
    /// <c>BatchDeleteCatalogObjects</c> succeeds even if only a portion of the targeted
    /// IDs can be deleted. The response will only include IDs that were
    /// actually deleted.
    /// </para>
    /// <para>
    /// To ensure consistency, only one delete request is processed at a time per seller account.
    /// While one (batch or non-batch) delete request is being processed, other (batched and non-batched)
    /// delete requests are rejected with the <c>429</c> error code.
    /// </para>
    /// </remarks>
    public Task<BatchDeleteCatalogObjectsResponse> BatchDeleteCatalogObjects(BatchDeleteCatalogObjectsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/batch-delete"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BatchDeleteCatalogObjectsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// BatchRetrieveCatalogObjects
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchRetrieveCatalogObjectsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a set of objects based on the provided ID.
    /// Each <see href="entity:CatalogItem">CatalogItem</see> returned in the set includes all of its
    /// child information including: all of its
    /// <see href="entity:CatalogItemVariation">CatalogItemVariation</see> objects, references to
    /// its <see href="entity:CatalogModifierList">CatalogModifierList</see> objects, and the ids of
    /// any <see href="entity:CatalogTax">CatalogTax</see> objects that apply to it.
    /// </remarks>
    public Task<BatchRetrieveCatalogObjectsResponse> BatchRetrieveCatalogObjects(BatchRetrieveCatalogObjectsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/batch-retrieve"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BatchRetrieveCatalogObjectsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// BatchUpsertCatalogObjects
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchUpsertCatalogObjectsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates or updates up to 10,000 target objects based on the provided
    /// list of objects. The target objects are grouped into batches and each batch is
    /// inserted/updated in an all-or-nothing manner. If an object within a batch is
    /// malformed in some way, or violates a database constraint, the entire batch
    /// containing that item will be disregarded. However, other batches in the same
    /// request may still succeed. Each batch may contain up to 1,000 objects, and
    /// batches will be processed in order as long as the total object count for the
    /// request (items, variations, modifier lists, discounts, and taxes) is no more
    /// than 10,000.
    /// <para>
    /// This endpoint uses full-replacement semantics. The client must send the complete object, and any
    /// field absent from the request is interpreted as an intentional clear. This logic applies to
    /// nested objects as well. For example, omitting inlined children like variations will delete them.
    /// </para>
    /// <para>
    /// To ensure consistency, only one update request is processed at a time per seller account.
    /// While one (batch or non-batch) update request is being processed, other (batched and non-batched)
    /// update requests are rejected with the <c>429</c> error code. Prefer batching related changes into a
    /// single call rather than issuing many small writes, since each write acquires the lock separately
    /// and parallel writes to the same seller will contend with each other, producing <c>429</c> errors.
    /// </para>
    /// </remarks>
    public Task<BatchUpsertCatalogObjectsResponse> BatchUpsertCatalogObjects(BatchUpsertCatalogObjectsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/batch-upsert"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BatchUpsertCatalogObjectsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// CatalogInfo
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CatalogInfoResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves information about the Square Catalog API, such as batch size
    /// limits that can be used by the <c>BatchUpsertCatalogObjects</c> endpoint.
    /// </remarks>
    public Task<CatalogInfoResponse> CatalogInfo(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/info"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CatalogInfoResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// CreateCatalogImage
    /// </summary>
    /// <param name="request"></param>
    /// <param name="imageFile"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateCatalogImageResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uploads an image file to be represented by a <see href="entity:CatalogImage">CatalogImage</see> object that can be linked to an existing
    /// <see href="entity:CatalogObject">CatalogObject</see> instance. The resulting <c>CatalogImage</c> is unattached to any <c>CatalogObject</c> if the <c>object_id</c>
    /// is not specified.
    /// <para>
    /// This <c>CreateCatalogImage</c> endpoint accepts HTTP multipart/form-data requests with a JSON part and an image file part in
    /// JPEG, PJPEG, PNG, or GIF format. The maximum file size is 15MB.
    /// </para>
    /// </remarks>
    public Task<CreateCatalogImageResponse> CreateCatalogImage(CreateCatalogImageRequest? request,
        BinaryContent? imageFile,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/images"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create([new MultipartParam("request", request, "application/json; charset=utf-8"),
                    new MultipartParam("image_file", imageFile)]),
            JsonResponse.Create<CreateCatalogImageResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// DeleteCatalogObject
    /// </summary>
    /// <param name="objectId">The ID of the catalog object to be deleted. When an object is deleted, other objects in the graph that depend on that object will be deleted as well (for example, deleting a catalog item will delete its catalog item variations).</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteCatalogObjectResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a single <see href="entity:CatalogObject">CatalogObject</see> based on the
    /// provided ID and returns the set of successfully deleted IDs in the response.
    /// Deletion is a cascading event such that all children of the targeted object
    /// are also deleted. For example, deleting a <see href="entity:CatalogItem">CatalogItem</see>
    /// will also delete all of its
    /// <see href="entity:CatalogItemVariation">CatalogItemVariation</see> children.
    /// <para>
    /// To ensure consistency, only one delete request is processed at a time per seller account.
    /// While one (batch or non-batch) delete request is being processed, other (batched and non-batched)
    /// delete requests are rejected with the <c>429</c> error code.
    /// </para>
    /// </remarks>
    public Task<DeleteCatalogObjectResponse> DeleteCatalogObject(string objectId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/object/{object_id}"),
            [new TemplateParam("object_id", objectId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteCatalogObjectResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListCatalog
    /// </summary>
    /// <param name="cursor">The pagination cursor returned in the previous response. Leave unset for an initial request. The page size is currently set to be 100. See <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see> for more information.</param>
    /// <param name="types">An optional case-insensitive, comma-separated list of object types to retrieve.  The valid values are defined in the <see href="entity:CatalogObjectType">CatalogObjectType</see> enum, for example, <c>ITEM</c>, <c>ITEM_VARIATION</c>, <c>CATEGORY</c>, <c>DISCOUNT</c>, <c>TAX</c>, <c>MODIFIER</c>, <c>MODIFIER_LIST</c>, <c>IMAGE</c>, etc.  If this is unspecified, the operation returns objects of all the top level types at the version of the Square API used to make the request. Object types that are nested onto other object types are not included in the defaults.  At the current API version the default object types are: ITEM, CATEGORY, TAX, DISCOUNT, MODIFIER_LIST,  PRICING_RULE, PRODUCT_SET, TIME_PERIOD, MEASUREMENT_UNIT, SUBSCRIPTION_PLAN, ITEM_OPTION, CUSTOM_ATTRIBUTE_DEFINITION, QUICK_AMOUNT_SETTINGS.</param>
    /// <param name="catalogVersion">The specific version of the catalog objects to be included in the response. This allows you to retrieve historical versions of objects. The specified version value is matched against the <see href="entity:CatalogObject">CatalogObject</see>s' <c>version</c> attribute.  If not included, results will be from the current version of the catalog.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCatalogResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all <see href="entity:CatalogObject">CatalogObject</see>s of the specified types in the catalog.
    /// <para>
    /// The <c>types</c> parameter is specified as a comma-separated list of the <see href="entity:CatalogObjectType">CatalogObjectType</see> values,
    /// for example, "<c>ITEM</c>, <c>ITEM_VARIATION</c>, <c>MODIFIER</c>, <c>MODIFIER_LIST</c>, <c>CATEGORY</c>, <c>DISCOUNT</c>, <c>TAX</c>, <c>IMAGE</c>".
    /// Always specify <c>types</c> explicitly. When upgrading to a newer API version, omitting <c>types</c> may
    /// cause new object types to appear in results that were not returned under the previous version.
    /// </para>
    /// <para>
    /// __Important:__ ListCatalog does not return deleted catalog items. To retrieve
    /// deleted catalog items, use <see href="api-endpoint:Catalog-SearchCatalogObjects">SearchCatalogObjects</see>
    /// and set the <c>include_deleted_objects</c> attribute value to <c>true</c>.
    /// </para>
    /// </remarks>
    public Task<ListCatalogResponse> ListCatalog(string? cursor,
        string? types,
        long? catalogVersion,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/list"),
            [],
            [new Param("cursor", cursor), new Param("types", types), new Param("catalog_version", catalogVersion)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCatalogResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveCatalogObject
    /// </summary>
    /// <param name="objectId">The object ID of any type of catalog objects to be retrieved.</param>
    /// <param name="catalogVersion">Requests objects as of a specific version of the catalog. This allows you to retrieve historical versions of objects. The value to retrieve a specific version of an object can be found in the version field of <see href="entity:CatalogObject">CatalogObject</see>s. If not included, results will be from the current version of the catalog.</param>
    /// <param name="includeRelatedObjects">If <c>true</c>, the response will include additional objects that are related to the requested objects. Related objects are defined as any objects referenced by ID by the results in the <c>objects</c> field of the response. These objects are put in the <c>related_objects</c> field. Setting this to <c>true</c> is helpful when the objects are needed for immediate display to a user. This process only goes one level deep. Objects referenced by the related objects will not be included. For example,  if the <c>objects</c> field of the response contains a CatalogItem, its associated CatalogCategory objects, CatalogTax objects, CatalogImage objects and CatalogModifierLists will be returned in the <c>related_objects</c> field of the response. If the <c>objects</c> field of the response contains a CatalogItemVariation, its parent CatalogItem will be returned in the <c>related_objects</c> field of the response.  Default value: <c>false</c></param>
    /// <param name="includeCategoryPathToRoot">Specifies whether or not to include the <c>path_to_root</c> list for each returned category instance. The <c>path_to_root</c> list consists of <c>CategoryPathToRootNode</c> objects and specifies the path that starts with the immediate parent category of the returned category and ends with its root category. If the returned category is a top-level category, the <c>path_to_root</c> list is empty and is not returned in the response payload.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveCatalogObjectResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a single <see href="entity:CatalogItem">CatalogItem</see> as a
    /// <see href="entity:CatalogObject">CatalogObject</see> based on the provided ID. The returned
    /// object includes all of the relevant <see href="entity:CatalogItem">CatalogItem</see>
    /// information including: <see href="entity:CatalogItemVariation">CatalogItemVariation</see>
    /// children, references to its
    /// <see href="entity:CatalogModifierList">CatalogModifierList</see> objects, and the ids of
    /// any <see href="entity:CatalogTax">CatalogTax</see> objects that apply to it.
    /// </remarks>
    public Task<RetrieveCatalogObjectResponse> RetrieveCatalogObject(string objectId,
        long? catalogVersion,
        bool? includeRelatedObjects = false,
        bool? includeCategoryPathToRoot = false,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/object/{object_id}"),
            [new TemplateParam("object_id", objectId)],
            [new Param("include_related_objects", includeRelatedObjects),
                new Param("catalog_version", catalogVersion),
                new Param("include_category_path_to_root", includeCategoryPathToRoot)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveCatalogObjectResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// SearchCatalogItems
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchCatalogItemsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches for catalog items or item variations by matching supported search attribute values, including
    /// custom attribute values, against one or more of the specified query filters.
    /// <para>
    /// This (<c>SearchCatalogItems</c>) endpoint differs from the <see href="api-endpoint:Catalog-SearchCatalogObjects">SearchCatalogObjects</see>
    /// endpoint in the following aspects:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>SearchCatalogItems</c> can only search for items or item variations, whereas <c>SearchCatalogObjects</c> can search for any type of catalog objects.</description></item>
    ///   <item><description><c>SearchCatalogItems</c> supports the custom attribute query filters to return items or item variations that contain custom attribute values, where <c>SearchCatalogObjects</c> does not.</description></item>
    ///   <item><description><c>SearchCatalogItems</c> does not support the <c>include_deleted_objects</c> filter to search for deleted items or item variations, whereas <c>SearchCatalogObjects</c> does.</description></item>
    ///   <item><description>The both endpoints use different call conventions, including the query filter formats.</description></item>
    /// </list>
    /// </remarks>
    public Task<SearchCatalogItemsResponse> SearchCatalogItems(SearchCatalogItemsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/search-catalog-items"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchCatalogItemsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// SearchCatalogObjects
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchCatalogObjectsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches for <see href="entity:CatalogObject">CatalogObject</see> of any type by matching supported search attribute values,
    /// excluding custom attribute values on items or item variations, against one or more of the specified query filters.
    /// <para>
    /// This (<c>SearchCatalogObjects</c>) endpoint differs from the <see href="api-endpoint:Catalog-SearchCatalogItems">SearchCatalogItems</see>
    /// endpoint in the following aspects:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>SearchCatalogItems</c> can only search for items or item variations, whereas <c>SearchCatalogObjects</c> can search for any type of catalog objects.</description></item>
    ///   <item><description><c>SearchCatalogItems</c> supports the custom attribute query filters to return items or item variations that contain custom attribute values, where <c>SearchCatalogObjects</c> does not.</description></item>
    ///   <item><description><c>SearchCatalogItems</c> does not support the <c>include_deleted_objects</c> filter to search for deleted items or item variations, whereas <c>SearchCatalogObjects</c> does.</description></item>
    ///   <item><description>The both endpoints have different call conventions, including the query filter formats.</description></item>
    /// </list>
    /// <para>
    /// The <c>object_types</c> parameter is specified as a list of <see href="entity:CatalogObjectType">CatalogObjectType</see> values.
    /// Always specify <c>object_types</c> explicitly. When upgrading to a newer API version, omitting
    /// <c>object_types</c> may cause new object types to appear in results that were not returned under
    /// the previous version.
    /// </para>
    /// </remarks>
    public Task<SearchCatalogObjectsResponse> SearchCatalogObjects(SearchCatalogObjectsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchCatalogObjectsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// UpdateCatalogImage
    /// </summary>
    /// <param name="imageId">The ID of the <c>CatalogImage</c> object to update the encapsulated image file.</param>
    /// <param name="request"></param>
    /// <param name="imageFile"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateCatalogImageResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uploads a new image file to replace the existing one in the specified <see href="entity:CatalogImage">CatalogImage</see> object.
    /// <para>
    /// This <c>UpdateCatalogImage</c> endpoint accepts HTTP multipart/form-data requests with a JSON part and an image file part in
    /// JPEG, PJPEG, PNG, or GIF format. The maximum file size is 15MB.
    /// </para>
    /// </remarks>
    public Task<UpdateCatalogImageResponse> UpdateCatalogImage(string imageId,
        UpdateCatalogImageRequest? request,
        BinaryContent? imageFile,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/images/{image_id}"),
            [new TemplateParam("image_id", imageId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            FormRequest.Create([new MultipartParam("request", request, "application/json; charset=utf-8"),
                    new MultipartParam("image_file", imageFile)]),
            JsonResponse.Create<UpdateCatalogImageResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// UpdateItemModifierLists
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateItemModifierListsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the <see href="entity:CatalogModifierList">CatalogModifierList</see> objects
    /// that apply to the targeted <see href="entity:CatalogItem">CatalogItem</see> without having
    /// to perform an upsert on the entire item.
    /// </remarks>
    public Task<UpdateItemModifierListsResponse> UpdateItemModifierLists(UpdateItemModifierListsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/update-item-modifier-lists"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateItemModifierListsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// UpdateItemTaxes
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateItemTaxesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the <see href="entity:CatalogTax">CatalogTax</see> objects that apply to the
    /// targeted <see href="entity:CatalogItem">CatalogItem</see> without having to perform an
    /// upsert on the entire item.
    /// </remarks>
    public Task<UpdateItemTaxesResponse> UpdateItemTaxes(UpdateItemTaxesRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/update-item-taxes"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateItemTaxesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// UpsertCatalogObject
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpsertCatalogObjectResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new or updates the specified <see href="entity:CatalogObject">CatalogObject</see>.
    /// <para>
    /// This endpoint uses full-replacement semantics. The client must send the complete object, and any
    /// field absent from the request is interpreted as an intentional clear. This logic applies to
    /// nested objects as well. For example, omitting inlined children like variations will delete them.
    /// </para>
    /// <para>
    /// To ensure consistency, only one update request is processed at a time per seller account.
    /// While one (batch or non-batch) update request is being processed, other (batched and non-batched)
    /// update requests are rejected with the <c>429</c> error code.
    /// </para>
    /// </remarks>
    public Task<UpsertCatalogObjectResponse> UpsertCatalogObject(UpsertCatalogObjectRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/object"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UpsertCatalogObjectResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);
}

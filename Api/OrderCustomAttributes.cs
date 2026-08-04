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

public sealed class OrderCustomAttributes
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal OrderCustomAttributes(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// BulkDeleteOrderCustomAttributes
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkDeleteOrderCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes order <see href="entity:CustomAttribute">custom attributes</see> as a bulk operation.
    /// <para>
    /// Use this endpoint to delete one or more custom attributes from one or more orders.
    /// A custom attribute is based on a custom attribute definition in a Square seller account.  (To create a
    /// custom attribute definition, use the <see href="api-endpoint:OrderCustomAttributes-CreateOrderCustomAttributeDefinition">CreateOrderCustomAttributeDefinition</see> endpoint.)
    /// </para>
    /// <para>
    /// This <c>BulkDeleteOrderCustomAttributes</c> endpoint accepts a map of 1 to 25 individual delete
    /// requests and returns a map of individual delete responses. Each delete request has a unique ID
    /// and provides an order ID and custom attribute. Each delete response is returned with the ID
    /// of the corresponding request.
    /// </para>
    /// <para>
    /// To delete a custom attribute owned by another application, the <c>visibility</c> setting
    /// must be <c>VISIBILITY_READ_WRITE_VALUES</c>. Note that seller-defined custom attributes
    /// (also known as custom fields) are always set to <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </para>
    /// </remarks>
    public Task<BulkDeleteOrderCustomAttributesResponse> BulkDeleteOrderCustomAttributes(BulkDeleteOrderCustomAttributesRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders/custom-attributes/bulk-delete"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BulkDeleteOrderCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// BulkUpsertOrderCustomAttributes
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkUpsertOrderCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates or updates order <see href="entity:CustomAttribute">custom attributes</see> as a bulk operation.
    /// <para>
    /// Use this endpoint to delete one or more custom attributes from one or more orders.
    /// A custom attribute is based on a custom attribute definition in a Square seller account.  (To create a
    /// custom attribute definition, use the <see href="api-endpoint:OrderCustomAttributes-CreateOrderCustomAttributeDefinition">CreateOrderCustomAttributeDefinition</see> endpoint.)
    /// </para>
    /// <para>
    /// This <c>BulkUpsertOrderCustomAttributes</c> endpoint accepts a map of 1 to 25 individual upsert
    /// requests and returns a map of individual upsert responses. Each upsert request has a unique ID
    /// and provides an order ID and custom attribute. Each upsert response is returned with the ID
    /// of the corresponding request.
    /// </para>
    /// <para>
    /// To create or update a custom attribute owned by another application, the <c>visibility</c> setting
    /// must be <c>VISIBILITY_READ_WRITE_VALUES</c>. Note that seller-defined custom attributes
    /// (also known as custom fields) are always set to <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </para>
    /// </remarks>
    public Task<BulkUpsertOrderCustomAttributesResponse> BulkUpsertOrderCustomAttributes(BulkUpsertOrderCustomAttributesRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders/custom-attributes/bulk-upsert"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BulkUpsertOrderCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// CreateOrderCustomAttributeDefinition
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateOrderCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates an order-related custom attribute definition.  Use this endpoint to
    /// define a custom attribute that can be associated with orders.
    /// <para>
    /// After creating a custom attribute definition, you can set the custom attribute for orders
    /// in the Square seller account.
    /// </para>
    /// </remarks>
    public Task<CreateOrderCustomAttributeDefinitionResponse> CreateOrderCustomAttributeDefinition(CreateOrderCustomAttributeDefinitionRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders/custom-attribute-definitions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateOrderCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// DeleteOrderCustomAttribute
    /// </summary>
    /// <param name="orderId">The ID of the target <see href="entity:Order">order</see>.</param>
    /// <param name="customAttributeKey">The key of the custom attribute to delete.  This key must match the key of an existing custom attribute definition.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteOrderCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a <see href="entity:CustomAttribute">custom attribute</see> associated with a customer profile.
    /// <para>
    /// To delete a custom attribute owned by another application, the <c>visibility</c> setting must be
    /// <c>VISIBILITY_READ_WRITE_VALUES</c>. Note that seller-defined custom attributes
    /// (also known as custom fields) are always set to <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </para>
    /// </remarks>
    public Task<DeleteOrderCustomAttributeResponse> DeleteOrderCustomAttribute(string orderId,
        string customAttributeKey,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders/{order_id}/custom-attributes/{custom_attribute_key}"),
            [new TemplateParam("order_id", orderId), new TemplateParam("custom_attribute_key", customAttributeKey)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteOrderCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// DeleteOrderCustomAttributeDefinition
    /// </summary>
    /// <param name="key">The key of the custom attribute definition to delete.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteOrderCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes an order-related <see href="entity:CustomAttributeDefinition">custom attribute definition</see> from a Square seller account.
    /// <para>
    /// Only the definition owner can delete a custom attribute definition.
    /// </para>
    /// </remarks>
    public Task<DeleteOrderCustomAttributeDefinitionResponse> DeleteOrderCustomAttributeDefinition(string key,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteOrderCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListOrderCustomAttributeDefinitions
    /// </summary>
    /// <param name="visibilityFilter">Requests that all of the custom attributes be returned, or only those that are read-only or read-write.</param>
    /// <param name="cursor">The cursor returned in the paged response from the previous call to this endpoint.  Provide this cursor to retrieve the next page of results for your original request.  For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.</param>
    /// <param name="limit">The maximum number of results to return in a single paged response. This limit is advisory.  The response might contain more or fewer results. The minimum value is 1 and the maximum value is 100.  The default value is 20. For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListOrderCustomAttributeDefinitionsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the order-related <see href="entity:CustomAttributeDefinition">custom attribute definitions</see> that belong to a Square seller account.
    /// <para>
    /// When all response pages are retrieved, the results include all custom attribute definitions
    /// that are visible to the requesting application, including those that are created by other
    /// applications and set to <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>. Note that
    /// seller-defined custom attributes (also known as custom fields) are always set to <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </para>
    /// </remarks>
    public Task<ListOrderCustomAttributeDefinitionsResponse> ListOrderCustomAttributeDefinitions(VisibilityFilter? visibilityFilter,
        string? cursor,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders/custom-attribute-definitions"),
            [],
            [new Param("visibility_filter", visibilityFilter),
                new Param("cursor", cursor),
                new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListOrderCustomAttributeDefinitionsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListOrderCustomAttributes
    /// </summary>
    /// <param name="orderId">The ID of the target <see href="entity:Order">order</see>.</param>
    /// <param name="visibilityFilter">Requests that all of the custom attributes be returned, or only those that are read-only or read-write.</param>
    /// <param name="cursor">The cursor returned in the paged response from the previous call to this endpoint.  Provide this cursor to retrieve the next page of results for your original request.  For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.</param>
    /// <param name="limit">The maximum number of results to return in a single paged response. This limit is advisory.  The response might contain more or fewer results. The minimum value is 1 and the maximum value is 100.  The default value is 20. For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.</param>
    /// <param name="withDefinitions">Indicates whether to return the <see href="entity:CustomAttributeDefinition">custom attribute definition</see> in the <c>definition</c> field of each custom attribute. Set this parameter to <c>true</c> to get the name and description of each custom attribute,  information about the data type, or other definition details. The default value is <c>false</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListOrderCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the <see href="entity:CustomAttribute">custom attributes</see> associated with an order.
    /// <para>
    /// You can use the <c>with_definitions</c> query parameter to also retrieve custom attribute definitions
    /// in the same call.
    /// </para>
    /// <para>
    /// When all response pages are retrieved, the results include all custom attributes that are
    /// visible to the requesting application, including those that are owned by other applications
    /// and set to <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </para>
    /// </remarks>
    public Task<ListOrderCustomAttributesResponse> ListOrderCustomAttributes(string orderId,
        VisibilityFilter? visibilityFilter,
        string? cursor,
        int? limit,
        bool? withDefinitions = false,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders/{order_id}/custom-attributes"),
            [new TemplateParam("order_id", orderId)],
            [new Param("visibility_filter", visibilityFilter),
                new Param("cursor", cursor),
                new Param("limit", limit),
                new Param("with_definitions", withDefinitions)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListOrderCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveOrderCustomAttribute
    /// </summary>
    /// <param name="orderId">The ID of the target <see href="entity:Order">order</see>.</param>
    /// <param name="customAttributeKey">The key of the custom attribute to retrieve.  This key must match the key of an existing custom attribute definition.</param>
    /// <param name="version">To enable <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/optimistic-concurrency">optimistic concurrency</see> control, include this optional field and specify the current version of the custom attribute.</param>
    /// <param name="withDefinition">Indicates whether to return the <see href="entity:CustomAttributeDefinition">custom attribute definition</see> in the <c>definition</c> field of each  custom attribute. Set this parameter to <c>true</c> to get the name and description of each custom attribute,  information about the data type, or other definition details. The default value is <c>false</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveOrderCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a <see href="entity:CustomAttribute">custom attribute</see> associated with an order.
    /// <para>
    /// You can use the <c>with_definition</c> query parameter to also retrieve the custom attribute definition
    /// in the same call.
    /// </para>
    /// <para>
    /// To retrieve a custom attribute owned by another application, the <c>visibility</c> setting must be
    /// <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>. Note that seller-defined custom attributes
    /// also known as custom fields) are always set to <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </para>
    /// </remarks>
    public Task<RetrieveOrderCustomAttributeResponse> RetrieveOrderCustomAttribute(string orderId,
        string customAttributeKey,
        int? version,
        bool? withDefinition = false,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders/{order_id}/custom-attributes/{custom_attribute_key}"),
            [new TemplateParam("order_id", orderId), new TemplateParam("custom_attribute_key", customAttributeKey)],
            [new Param("version", version), new Param("with_definition", withDefinition)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveOrderCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveOrderCustomAttributeDefinition
    /// </summary>
    /// <param name="key">The key of the custom attribute definition to retrieve.</param>
    /// <param name="version">To enable <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/optimistic-concurrency">optimistic concurrency</see> control, include this optional field and specify the current version of the custom attribute.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveOrderCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves an order-related <see href="entity:CustomAttributeDefinition">custom attribute definition</see> from a Square seller account.
    /// <para>
    /// To retrieve a custom attribute definition created by another application, the <c>visibility</c>
    /// setting must be <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>. Note that seller-defined custom attributes
    /// (also known as custom fields) are always set to <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </para>
    /// </remarks>
    public Task<RetrieveOrderCustomAttributeDefinitionResponse> RetrieveOrderCustomAttributeDefinition(string key,
        int? version,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", key)],
            [new Param("version", version)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveOrderCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// UpdateOrderCustomAttributeDefinition
    /// </summary>
    /// <param name="key">The key of the custom attribute definition to update.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateOrderCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates an order-related custom attribute definition for a Square seller account.
    /// <para>
    /// Only the definition owner can update a custom attribute definition. Note that sellers can view all custom attributes in exported customer data, including those set to <c>VISIBILITY_HIDDEN</c>.
    /// </para>
    /// </remarks>
    public Task<UpdateOrderCustomAttributeDefinitionResponse> UpdateOrderCustomAttributeDefinition(string key,
        UpdateOrderCustomAttributeDefinitionRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateOrderCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// UpsertOrderCustomAttribute
    /// </summary>
    /// <param name="orderId">The ID of the target <see href="entity:Order">order</see>.</param>
    /// <param name="customAttributeKey">The key of the custom attribute to create or update.  This key must match the key  of an existing custom attribute definition.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpsertOrderCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates or updates a <see href="entity:CustomAttribute">custom attribute</see> for an order.
    /// <para>
    /// Use this endpoint to set the value of a custom attribute for a specific order.
    /// A custom attribute is based on a custom attribute definition in a Square seller account. (To create a
    /// custom attribute definition, use the <see href="api-endpoint:OrderCustomAttributes-CreateOrderCustomAttributeDefinition">CreateOrderCustomAttributeDefinition</see> endpoint.)
    /// </para>
    /// <para>
    /// To create or update a custom attribute owned by another application, the <c>visibility</c> setting
    /// must be <c>VISIBILITY_READ_WRITE_VALUES</c>. Note that seller-defined custom attributes
    /// (also known as custom fields) are always set to <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </para>
    /// </remarks>
    public Task<UpsertOrderCustomAttributeResponse> UpsertOrderCustomAttribute(string orderId,
        string customAttributeKey,
        UpsertOrderCustomAttributeRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders/{order_id}/custom-attributes/{custom_attribute_key}"),
            [new TemplateParam("order_id", orderId), new TemplateParam("custom_attribute_key", customAttributeKey)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UpsertOrderCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);
}

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
using Square.Requests.OrderCustomAttributes;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkDeleteOrderCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<BulkDeleteOrderCustomAttributesResponse> BulkDeleteOrderCustomAttributes(BulkDeleteOrderCustomAttributesOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/orders/custom-attributes/bulk-delete"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BulkDeleteOrderCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// BulkUpsertOrderCustomAttributes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkUpsertOrderCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<BulkUpsertOrderCustomAttributesResponse> BulkUpsertOrderCustomAttributes(BulkUpsertOrderCustomAttributesOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/orders/custom-attributes/bulk-upsert"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BulkUpsertOrderCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CreateOrderCustomAttributeDefinition
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateOrderCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates an order-related custom attribute definition.  Use this endpoint to
    /// define a custom attribute that can be associated with orders.
    /// <para>
    /// After creating a custom attribute definition, you can set the custom attribute for orders
    /// in the Square seller account.
    /// </para>
    /// </remarks>
    public Task<CreateOrderCustomAttributeDefinitionResponse> CreateOrderCustomAttributeDefinition(CreateOrderCustomAttributeDefinitionOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/orders/custom-attribute-definitions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateOrderCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeleteOrderCustomAttribute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteOrderCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a <see href="entity:CustomAttribute">custom attribute</see> associated with a customer profile.
    /// <para>
    /// To delete a custom attribute owned by another application, the <c>visibility</c> setting must be
    /// <c>VISIBILITY_READ_WRITE_VALUES</c>. Note that seller-defined custom attributes
    /// (also known as custom fields) are always set to <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </para>
    /// </remarks>
    public Task<DeleteOrderCustomAttributeResponse> DeleteOrderCustomAttribute(DeleteOrderCustomAttributeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/orders/{order_id}/custom-attributes/{custom_attribute_key}"),
            [
                new TemplateParam("order_id", request.OrderId),
                new TemplateParam("custom_attribute_key", request.CustomAttributeKey),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteOrderCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeleteOrderCustomAttributeDefinition
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteOrderCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes an order-related <see href="entity:CustomAttributeDefinition">custom attribute definition</see> from a Square seller account.
    /// <para>
    /// Only the definition owner can delete a custom attribute definition.
    /// </para>
    /// </remarks>
    public Task<DeleteOrderCustomAttributeDefinitionResponse> DeleteOrderCustomAttributeDefinition(DeleteOrderCustomAttributeDefinitionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/orders/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", request.Key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteOrderCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListOrderCustomAttributeDefinitions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListOrderCustomAttributeDefinitionsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the order-related <see href="entity:CustomAttributeDefinition">custom attribute definitions</see> that belong to a Square seller account.
    /// <para>
    /// When all response pages are retrieved, the results include all custom attribute definitions
    /// that are visible to the requesting application, including those that are created by other
    /// applications and set to <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>. Note that
    /// seller-defined custom attributes (also known as custom fields) are always set to <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </para>
    /// </remarks>
    public Task<ListOrderCustomAttributeDefinitionsResponse> ListOrderCustomAttributeDefinitions(ListOrderCustomAttributeDefinitionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/orders/custom-attribute-definitions"),
            [],
            [
                new Param("visibility_filter", request.VisibilityFilter),
                new Param("cursor", request.Cursor),
                new Param("limit", request.Limit),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListOrderCustomAttributeDefinitionsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListOrderCustomAttributes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListOrderCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<ListOrderCustomAttributesResponse> ListOrderCustomAttributes(ListOrderCustomAttributesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/orders/{order_id}/custom-attributes"),
            [new TemplateParam("order_id", request.OrderId)],
            [
                new Param("visibility_filter", request.VisibilityFilter),
                new Param("cursor", request.Cursor),
                new Param("limit", request.Limit),
                new Param("with_definitions", request.WithDefinitions),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListOrderCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveOrderCustomAttribute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveOrderCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<RetrieveOrderCustomAttributeResponse> RetrieveOrderCustomAttribute(RetrieveOrderCustomAttributeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/orders/{order_id}/custom-attributes/{custom_attribute_key}"),
            [
                new TemplateParam("order_id", request.OrderId),
                new TemplateParam("custom_attribute_key", request.CustomAttributeKey),
            ],
            [new Param("version", request.Version), new Param("with_definition", request.WithDefinition)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveOrderCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveOrderCustomAttributeDefinition
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveOrderCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves an order-related <see href="entity:CustomAttributeDefinition">custom attribute definition</see> from a Square seller account.
    /// <para>
    /// To retrieve a custom attribute definition created by another application, the <c>visibility</c>
    /// setting must be <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>. Note that seller-defined custom attributes
    /// (also known as custom fields) are always set to <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </para>
    /// </remarks>
    public Task<RetrieveOrderCustomAttributeDefinitionResponse> RetrieveOrderCustomAttributeDefinition(RetrieveOrderCustomAttributeDefinitionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/orders/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", request.Key)],
            [new Param("version", request.Version)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveOrderCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpdateOrderCustomAttributeDefinition
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateOrderCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates an order-related custom attribute definition for a Square seller account.
    /// <para>
    /// Only the definition owner can update a custom attribute definition. Note that sellers can view all custom attributes in exported customer data, including those set to <c>VISIBILITY_HIDDEN</c>.
    /// </para>
    /// </remarks>
    public Task<UpdateOrderCustomAttributeDefinitionResponse> UpdateOrderCustomAttributeDefinition(UpdateOrderCustomAttributeDefinitionOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/orders/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", request.Key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateOrderCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpsertOrderCustomAttribute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpsertOrderCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<UpsertOrderCustomAttributeResponse> UpsertOrderCustomAttribute(UpsertOrderCustomAttributeOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/orders/{order_id}/custom-attributes/{custom_attribute_key}"),
            [
                new TemplateParam("order_id", request.OrderId),
                new TemplateParam("custom_attribute_key", request.CustomAttributeKey),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpsertOrderCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}

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
using Square.Requests.MerchantCustomAttributes;

namespace Square.Api;

public sealed class MerchantCustomAttributes
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal MerchantCustomAttributes(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// BulkDeleteMerchantCustomAttributes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkDeleteMerchantCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes <see href="entity:CustomAttribute">custom attributes</see> for a merchant as a bulk operation.
    /// To delete a custom attribute owned by another application, the <c>visibility</c> setting must be
    /// <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </remarks>
    public Task<BulkDeleteMerchantCustomAttributesResponse> BulkDeleteMerchantCustomAttributes(BulkDeleteMerchantCustomAttributesOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/merchants/custom-attributes/bulk-delete"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BulkDeleteMerchantCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// BulkUpsertMerchantCustomAttributes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkUpsertMerchantCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates or updates <see href="entity:CustomAttribute">custom attributes</see> for a merchant as a bulk operation.
    /// Use this endpoint to set the value of one or more custom attributes for a merchant.
    /// A custom attribute is based on a custom attribute definition in a Square seller account, which is
    /// created using the <see href="api-endpoint:MerchantCustomAttributes-CreateMerchantCustomAttributeDefinition">CreateMerchantCustomAttributeDefinition</see> endpoint.
    /// This <c>BulkUpsertMerchantCustomAttributes</c> endpoint accepts a map of 1 to 25 individual upsert
    /// requests and returns a map of individual upsert responses. Each upsert request has a unique ID
    /// and provides a merchant ID and custom attribute. Each upsert response is returned with the ID
    /// of the corresponding request.
    /// To create or update a custom attribute owned by another application, the <c>visibility</c> setting
    /// must be <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </remarks>
    public Task<BulkUpsertMerchantCustomAttributesResponse> BulkUpsertMerchantCustomAttributes(BulkUpsertMerchantCustomAttributesOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/merchants/custom-attributes/bulk-upsert"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BulkUpsertMerchantCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CreateMerchantCustomAttributeDefinition
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateMerchantCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a merchant-related <see href="entity:CustomAttributeDefinition">custom attribute definition</see> for a Square seller account.
    /// Use this endpoint to define a custom attribute that can be associated with a merchant connecting to your application.
    /// A custom attribute definition specifies the <c>key</c>, <c>visibility</c>, <c>schema</c>, and other properties
    /// for a custom attribute. After the definition is created, you can call
    /// <see href="api-endpoint:MerchantCustomAttributes-UpsertMerchantCustomAttribute">UpsertMerchantCustomAttribute</see> or
    /// <see href="api-endpoint:MerchantCustomAttributes-BulkUpsertMerchantCustomAttributes">BulkUpsertMerchantCustomAttributes</see>
    /// to set the custom attribute for a merchant.
    /// </remarks>
    public Task<CreateMerchantCustomAttributeDefinitionResponse> CreateMerchantCustomAttributeDefinition(CreateMerchantCustomAttributeDefinitionOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/merchants/custom-attribute-definitions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateMerchantCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeleteMerchantCustomAttribute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteMerchantCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a <see href="entity:CustomAttribute">custom attribute</see> associated with a merchant.
    /// To delete a custom attribute owned by another application, the <c>visibility</c> setting must be
    /// <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </remarks>
    public Task<DeleteMerchantCustomAttributeResponse> DeleteMerchantCustomAttribute(DeleteMerchantCustomAttributeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/merchants/{merchant_id}/custom-attributes/{key}"),
            [new TemplateParam("merchant_id", request.MerchantId), new TemplateParam("key", request.Key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteMerchantCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeleteMerchantCustomAttributeDefinition
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteMerchantCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a merchant-related <see href="entity:CustomAttributeDefinition">custom attribute definition</see> from a Square seller account.
    /// Deleting a custom attribute definition also deletes the corresponding custom attribute from
    /// the merchant.
    /// Only the definition owner can delete a custom attribute definition.
    /// </remarks>
    public Task<DeleteMerchantCustomAttributeDefinitionResponse> DeleteMerchantCustomAttributeDefinition(DeleteMerchantCustomAttributeDefinitionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/merchants/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", request.Key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteMerchantCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListMerchantCustomAttributeDefinitions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListMerchantCustomAttributeDefinitionsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the merchant-related <see href="entity:CustomAttributeDefinition">custom attribute definitions</see> that belong to a Square seller account.
    /// When all response pages are retrieved, the results include all custom attribute definitions
    /// that are visible to the requesting application, including those that are created by other
    /// applications and set to <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </remarks>
    public Task<ListMerchantCustomAttributeDefinitionsResponse> ListMerchantCustomAttributeDefinitions(ListMerchantCustomAttributeDefinitionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/merchants/custom-attribute-definitions"),
            [],
            [
                new Param("visibility_filter", request.VisibilityFilter),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListMerchantCustomAttributeDefinitionsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListMerchantCustomAttributes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListMerchantCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the <see href="entity:CustomAttribute">custom attributes</see> associated with a merchant.
    /// You can use the <c>with_definitions</c> query parameter to also retrieve custom attribute definitions
    /// in the same call.
    /// When all response pages are retrieved, the results include all custom attributes that are
    /// visible to the requesting application, including those that are owned by other applications
    /// and set to <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </remarks>
    public Task<ListMerchantCustomAttributesResponse> ListMerchantCustomAttributes(ListMerchantCustomAttributesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/merchants/{merchant_id}/custom-attributes"),
            [new TemplateParam("merchant_id", request.MerchantId)],
            [
                new Param("visibility_filter", request.VisibilityFilter),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
                new Param("with_definitions", request.WithDefinitions),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListMerchantCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveMerchantCustomAttribute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveMerchantCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a <see href="entity:CustomAttribute">custom attribute</see> associated with a merchant.
    /// You can use the <c>with_definition</c> query parameter to also retrieve the custom attribute definition
    /// in the same call.
    /// To retrieve a custom attribute owned by another application, the <c>visibility</c> setting must be
    /// <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </remarks>
    public Task<RetrieveMerchantCustomAttributeResponse> RetrieveMerchantCustomAttribute(RetrieveMerchantCustomAttributeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/merchants/{merchant_id}/custom-attributes/{key}"),
            [new TemplateParam("merchant_id", request.MerchantId), new TemplateParam("key", request.Key)],
            [new Param("with_definition", request.WithDefinition), new Param("version", request.Version)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveMerchantCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveMerchantCustomAttributeDefinition
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveMerchantCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a merchant-related <see href="entity:CustomAttributeDefinition">custom attribute definition</see> from a Square seller account.
    /// To retrieve a custom attribute definition created by another application, the <c>visibility</c>
    /// setting must be <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </remarks>
    public Task<RetrieveMerchantCustomAttributeDefinitionResponse> RetrieveMerchantCustomAttributeDefinition(RetrieveMerchantCustomAttributeDefinitionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/merchants/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", request.Key)],
            [new Param("version", request.Version)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveMerchantCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpdateMerchantCustomAttributeDefinition
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateMerchantCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a merchant-related <see href="entity:CustomAttributeDefinition">custom attribute definition</see> for a Square seller account.
    /// Use this endpoint to update the following fields: <c>name</c>, <c>description</c>, <c>visibility</c>, or the
    /// <c>schema</c> for a <c>Selection</c> data type.
    /// Only the definition owner can update a custom attribute definition.
    /// </remarks>
    public Task<UpdateMerchantCustomAttributeDefinitionResponse> UpdateMerchantCustomAttributeDefinition(UpdateMerchantCustomAttributeDefinitionOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/merchants/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", request.Key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateMerchantCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpsertMerchantCustomAttribute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpsertMerchantCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates or updates a <see href="entity:CustomAttribute">custom attribute</see> for a merchant.
    /// Use this endpoint to set the value of a custom attribute for a specified merchant.
    /// A custom attribute is based on a custom attribute definition in a Square seller account, which
    /// is created using the <see href="api-endpoint:MerchantCustomAttributes-CreateMerchantCustomAttributeDefinition">CreateMerchantCustomAttributeDefinition</see> endpoint.
    /// To create or update a custom attribute owned by another application, the <c>visibility</c> setting
    /// must be <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </remarks>
    public Task<UpsertMerchantCustomAttributeResponse> UpsertMerchantCustomAttribute(UpsertMerchantCustomAttributeOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/merchants/{merchant_id}/custom-attributes/{key}"),
            [new TemplateParam("merchant_id", request.MerchantId), new TemplateParam("key", request.Key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpsertMerchantCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}

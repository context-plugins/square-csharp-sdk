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
using Square.Requests.LocationCustomAttributes;

namespace Square.Api;

public sealed class LocationCustomAttributes
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal LocationCustomAttributes(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// BulkDeleteLocationCustomAttributes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkDeleteLocationCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes <see href="entity:CustomAttribute">custom attributes</see> for locations as a bulk operation.
    /// To delete a custom attribute owned by another application, the <c>visibility</c> setting must be
    /// <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </remarks>
    public Task<BulkDeleteLocationCustomAttributesResponse> BulkDeleteLocationCustomAttributes(BulkDeleteLocationCustomAttributesOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/locations/custom-attributes/bulk-delete"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BulkDeleteLocationCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// BulkUpsertLocationCustomAttributes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkUpsertLocationCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates or updates <see href="entity:CustomAttribute">custom attributes</see> for locations as a bulk operation.
    /// Use this endpoint to set the value of one or more custom attributes for one or more locations.
    /// A custom attribute is based on a custom attribute definition in a Square seller account, which is
    /// created using the <see href="api-endpoint:LocationCustomAttributes-CreateLocationCustomAttributeDefinition">CreateLocationCustomAttributeDefinition</see> endpoint.
    /// This <c>BulkUpsertLocationCustomAttributes</c> endpoint accepts a map of 1 to 25 individual upsert
    /// requests and returns a map of individual upsert responses. Each upsert request has a unique ID
    /// and provides a location ID and custom attribute. Each upsert response is returned with the ID
    /// of the corresponding request.
    /// To create or update a custom attribute owned by another application, the <c>visibility</c> setting
    /// must be <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </remarks>
    public Task<BulkUpsertLocationCustomAttributesResponse> BulkUpsertLocationCustomAttributes(BulkUpsertLocationCustomAttributesOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/locations/custom-attributes/bulk-upsert"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BulkUpsertLocationCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CreateLocationCustomAttributeDefinition
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateLocationCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a location-related <see href="entity:CustomAttributeDefinition">custom attribute definition</see> for a Square seller account.
    /// Use this endpoint to define a custom attribute that can be associated with locations.
    /// A custom attribute definition specifies the <c>key</c>, <c>visibility</c>, <c>schema</c>, and other properties
    /// for a custom attribute. After the definition is created, you can call
    /// <see href="api-endpoint:LocationCustomAttributes-UpsertLocationCustomAttribute">UpsertLocationCustomAttribute</see> or
    /// <see href="api-endpoint:LocationCustomAttributes-BulkUpsertLocationCustomAttributes">BulkUpsertLocationCustomAttributes</see>
    /// to set the custom attribute for locations.
    /// </remarks>
    public Task<CreateLocationCustomAttributeDefinitionResponse> CreateLocationCustomAttributeDefinition(CreateLocationCustomAttributeDefinitionOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/locations/custom-attribute-definitions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateLocationCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeleteLocationCustomAttribute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteLocationCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a <see href="entity:CustomAttribute">custom attribute</see> associated with a location.
    /// To delete a custom attribute owned by another application, the <c>visibility</c> setting must be
    /// <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </remarks>
    public Task<DeleteLocationCustomAttributeResponse> DeleteLocationCustomAttribute(DeleteLocationCustomAttributeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/locations/{location_id}/custom-attributes/{key}"),
            [new TemplateParam("location_id", request.LocationId), new TemplateParam("key", request.Key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteLocationCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeleteLocationCustomAttributeDefinition
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteLocationCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a location-related <see href="entity:CustomAttributeDefinition">custom attribute definition</see> from a Square seller account.
    /// Deleting a custom attribute definition also deletes the corresponding custom attribute from
    /// all locations.
    /// Only the definition owner can delete a custom attribute definition.
    /// </remarks>
    public Task<DeleteLocationCustomAttributeDefinitionResponse> DeleteLocationCustomAttributeDefinition(DeleteLocationCustomAttributeDefinitionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/locations/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", request.Key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteLocationCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListLocationCustomAttributeDefinitions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListLocationCustomAttributeDefinitionsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the location-related <see href="entity:CustomAttributeDefinition">custom attribute definitions</see> that belong to a Square seller account.
    /// When all response pages are retrieved, the results include all custom attribute definitions
    /// that are visible to the requesting application, including those that are created by other
    /// applications and set to <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </remarks>
    public Task<ListLocationCustomAttributeDefinitionsResponse> ListLocationCustomAttributeDefinitions(ListLocationCustomAttributeDefinitionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/locations/custom-attribute-definitions"),
            [],
            [
                new Param("visibility_filter", request.VisibilityFilter),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListLocationCustomAttributeDefinitionsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListLocationCustomAttributes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListLocationCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the <see href="entity:CustomAttribute">custom attributes</see> associated with a location.
    /// You can use the <c>with_definitions</c> query parameter to also retrieve custom attribute definitions
    /// in the same call.
    /// When all response pages are retrieved, the results include all custom attributes that are
    /// visible to the requesting application, including those that are owned by other applications
    /// and set to <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </remarks>
    public Task<ListLocationCustomAttributesResponse> ListLocationCustomAttributes(ListLocationCustomAttributesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/locations/{location_id}/custom-attributes"),
            [new TemplateParam("location_id", request.LocationId)],
            [
                new Param("visibility_filter", request.VisibilityFilter),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
                new Param("with_definitions", request.WithDefinitions),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListLocationCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveLocationCustomAttribute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveLocationCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a <see href="entity:CustomAttribute">custom attribute</see> associated with a location.
    /// You can use the <c>with_definition</c> query parameter to also retrieve the custom attribute definition
    /// in the same call.
    /// To retrieve a custom attribute owned by another application, the <c>visibility</c> setting must be
    /// <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </remarks>
    public Task<RetrieveLocationCustomAttributeResponse> RetrieveLocationCustomAttribute(RetrieveLocationCustomAttributeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/locations/{location_id}/custom-attributes/{key}"),
            [new TemplateParam("location_id", request.LocationId), new TemplateParam("key", request.Key)],
            [new Param("with_definition", request.WithDefinition), new Param("version", request.Version)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveLocationCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveLocationCustomAttributeDefinition
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveLocationCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a location-related <see href="entity:CustomAttributeDefinition">custom attribute definition</see> from a Square seller account.
    /// To retrieve a custom attribute definition created by another application, the <c>visibility</c>
    /// setting must be <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </remarks>
    public Task<RetrieveLocationCustomAttributeDefinitionResponse> RetrieveLocationCustomAttributeDefinition(RetrieveLocationCustomAttributeDefinitionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/locations/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", request.Key)],
            [new Param("version", request.Version)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveLocationCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpdateLocationCustomAttributeDefinition
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateLocationCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a location-related <see href="entity:CustomAttributeDefinition">custom attribute definition</see> for a Square seller account.
    /// Use this endpoint to update the following fields: <c>name</c>, <c>description</c>, <c>visibility</c>, or the
    /// <c>schema</c> for a <c>Selection</c> data type.
    /// Only the definition owner can update a custom attribute definition.
    /// </remarks>
    public Task<UpdateLocationCustomAttributeDefinitionResponse> UpdateLocationCustomAttributeDefinition(UpdateLocationCustomAttributeDefinitionOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/locations/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", request.Key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateLocationCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpsertLocationCustomAttribute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpsertLocationCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates or updates a <see href="entity:CustomAttribute">custom attribute</see> for a location.
    /// Use this endpoint to set the value of a custom attribute for a specified location.
    /// A custom attribute is based on a custom attribute definition in a Square seller account, which
    /// is created using the <see href="api-endpoint:LocationCustomAttributes-CreateLocationCustomAttributeDefinition">CreateLocationCustomAttributeDefinition</see> endpoint.
    /// To create or update a custom attribute owned by another application, the <c>visibility</c> setting
    /// must be <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </remarks>
    public Task<UpsertLocationCustomAttributeResponse> UpsertLocationCustomAttribute(UpsertLocationCustomAttributeOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/locations/{location_id}/custom-attributes/{key}"),
            [new TemplateParam("location_id", request.LocationId), new TemplateParam("key", request.Key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpsertLocationCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}

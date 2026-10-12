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
using Square.Requests.CustomerCustomAttributes;

namespace Square.Api;

public sealed class CustomerCustomAttributes
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal CustomerCustomAttributes(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// BulkUpsertCustomerCustomAttributes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkUpsertCustomerCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates or updates <see href="entity:CustomAttribute">custom attributes</see> for customer profiles as a bulk operation.
    /// <para>
    /// Use this endpoint to set the value of one or more custom attributes for one or more customer profiles.
    /// A custom attribute is based on a custom attribute definition in a Square seller account, which is
    /// created using the <see href="api-endpoint:CustomerCustomAttributes-CreateCustomerCustomAttributeDefinition">CreateCustomerCustomAttributeDefinition</see> endpoint.
    /// </para>
    /// <para>
    /// This <c>BulkUpsertCustomerCustomAttributes</c> endpoint accepts a map of 1 to 25 individual upsert
    /// requests and returns a map of individual upsert responses. Each upsert request has a unique ID
    /// and provides a customer ID and custom attribute. Each upsert response is returned with the ID
    /// of the corresponding request.
    /// </para>
    /// <para>
    /// To create or update a custom attribute owned by another application, the <c>visibility</c> setting
    /// must be <c>VISIBILITY_READ_WRITE_VALUES</c>. Note that seller-defined custom attributes
    /// (also known as custom fields) are always set to <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </para>
    /// </remarks>
    public Task<BulkUpsertCustomerCustomAttributesResponse> BulkUpsertCustomerCustomAttributes(BulkUpsertCustomerCustomAttributesOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/custom-attributes/bulk-upsert"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BulkUpsertCustomerCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CreateCustomerCustomAttributeDefinition
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateCustomerCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a customer-related <see href="entity:CustomAttributeDefinition">custom attribute definition</see> for a Square seller account.
    /// Use this endpoint to define a custom attribute that can be associated with customer profiles.
    /// <para>
    /// A custom attribute definition specifies the <c>key</c>, <c>visibility</c>, <c>schema</c>, and other properties
    /// for a custom attribute. After the definition is created, you can call
    /// <see href="api-endpoint:CustomerCustomAttributes-UpsertCustomerCustomAttribute">UpsertCustomerCustomAttribute</see> or
    /// <see href="api-endpoint:CustomerCustomAttributes-BulkUpsertCustomerCustomAttributes">BulkUpsertCustomerCustomAttributes</see>
    /// to set the custom attribute for customer profiles in the seller's Customer Directory.
    /// </para>
    /// <para>
    /// Sellers can view all custom attributes in exported customer data, including those set to
    /// <c>VISIBILITY_HIDDEN</c>.
    /// </para>
    /// </remarks>
    public Task<CreateCustomerCustomAttributeDefinitionResponse> CreateCustomerCustomAttributeDefinition(CreateCustomerCustomAttributeDefinitionOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/custom-attribute-definitions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateCustomerCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeleteCustomerCustomAttribute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteCustomerCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a <see href="entity:CustomAttribute">custom attribute</see> associated with a customer profile.
    /// <para>
    /// To delete a custom attribute owned by another application, the <c>visibility</c> setting must be
    /// <c>VISIBILITY_READ_WRITE_VALUES</c>. Note that seller-defined custom attributes
    /// (also known as custom fields) are always set to <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </para>
    /// </remarks>
    public Task<DeleteCustomerCustomAttributeResponse> DeleteCustomerCustomAttribute(DeleteCustomerCustomAttributeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/{customer_id}/custom-attributes/{key}"),
            [new TemplateParam("customer_id", request.CustomerId), new TemplateParam("key", request.Key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteCustomerCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeleteCustomerCustomAttributeDefinition
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteCustomerCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a customer-related <see href="entity:CustomAttributeDefinition">custom attribute definition</see> from a Square seller account.
    /// <para>
    /// Deleting a custom attribute definition also deletes the corresponding custom attribute from
    /// all customer profiles in the seller's Customer Directory.
    /// </para>
    /// <para>
    /// Only the definition owner can delete a custom attribute definition.
    /// </para>
    /// </remarks>
    public Task<DeleteCustomerCustomAttributeDefinitionResponse> DeleteCustomerCustomAttributeDefinition(DeleteCustomerCustomAttributeDefinitionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", request.Key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteCustomerCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListCustomerCustomAttributeDefinitions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCustomerCustomAttributeDefinitionsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the customer-related <see href="entity:CustomAttributeDefinition">custom attribute definitions</see> that belong to a Square seller account.
    /// <para>
    /// When all response pages are retrieved, the results include all custom attribute definitions
    /// that are visible to the requesting application, including those that are created by other
    /// applications and set to <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>. Note that
    /// seller-defined custom attributes (also known as custom fields) are always set to <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </para>
    /// </remarks>
    public Task<ListCustomerCustomAttributeDefinitionsResponse> ListCustomerCustomAttributeDefinitions(ListCustomerCustomAttributeDefinitionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/custom-attribute-definitions"),
            [],
            [new Param("limit", request.Limit), new Param("cursor", request.Cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCustomerCustomAttributeDefinitionsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListCustomerCustomAttributes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCustomerCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the <see href="entity:CustomAttribute">custom attributes</see> associated with a customer profile.
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
    public Task<ListCustomerCustomAttributesResponse> ListCustomerCustomAttributes(ListCustomerCustomAttributesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/{customer_id}/custom-attributes"),
            [new TemplateParam("customer_id", request.CustomerId)],
            [
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
                new Param("with_definitions", request.WithDefinitions),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCustomerCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveCustomerCustomAttribute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveCustomerCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a <see href="entity:CustomAttribute">custom attribute</see> associated with a customer profile.
    /// <para>
    /// You can use the <c>with_definition</c> query parameter to also retrieve the custom attribute definition
    /// in the same call.
    /// </para>
    /// <para>
    /// To retrieve a custom attribute owned by another application, the <c>visibility</c> setting must be
    /// <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>. Note that seller-defined custom attributes
    /// (also known as custom fields) are always set to <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </para>
    /// </remarks>
    public Task<RetrieveCustomerCustomAttributeResponse> RetrieveCustomerCustomAttribute(RetrieveCustomerCustomAttributeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/{customer_id}/custom-attributes/{key}"),
            [new TemplateParam("customer_id", request.CustomerId), new TemplateParam("key", request.Key)],
            [new Param("with_definition", request.WithDefinition), new Param("version", request.Version)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveCustomerCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveCustomerCustomAttributeDefinition
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveCustomerCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a customer-related <see href="entity:CustomAttributeDefinition">custom attribute definition</see> from a Square seller account.
    /// <para>
    /// To retrieve a custom attribute definition created by another application, the <c>visibility</c>
    /// setting must be <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>. Note that seller-defined custom attributes
    /// (also known as custom fields) are always set to <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </para>
    /// </remarks>
    public Task<RetrieveCustomerCustomAttributeDefinitionResponse> RetrieveCustomerCustomAttributeDefinition(RetrieveCustomerCustomAttributeDefinitionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", request.Key)],
            [new Param("version", request.Version)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveCustomerCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpdateCustomerCustomAttributeDefinition
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateCustomerCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a customer-related <see href="entity:CustomAttributeDefinition">custom attribute definition</see> for a Square seller account.
    /// <para>
    /// Use this endpoint to update the following fields: <c>name</c>, <c>description</c>, <c>visibility</c>, or the
    /// <c>schema</c> for a <c>Selection</c> data type.
    /// </para>
    /// <para>
    /// Only the definition owner can update a custom attribute definition. Note that sellers can view
    /// all custom attributes in exported customer data, including those set to <c>VISIBILITY_HIDDEN</c>.
    /// </para>
    /// </remarks>
    public Task<UpdateCustomerCustomAttributeDefinitionResponse> UpdateCustomerCustomAttributeDefinition(UpdateCustomerCustomAttributeDefinitionOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", request.Key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateCustomerCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpsertCustomerCustomAttribute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpsertCustomerCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates or updates a <see href="entity:CustomAttribute">custom attribute</see> for a customer profile.
    /// <para>
    /// Use this endpoint to set the value of a custom attribute for a specified customer profile.
    /// A custom attribute is based on a custom attribute definition in a Square seller account, which
    /// is created using the <see href="api-endpoint:CustomerCustomAttributes-CreateCustomerCustomAttributeDefinition">CreateCustomerCustomAttributeDefinition</see> endpoint.
    /// </para>
    /// <para>
    /// To create or update a custom attribute owned by another application, the <c>visibility</c> setting
    /// must be <c>VISIBILITY_READ_WRITE_VALUES</c>. Note that seller-defined custom attributes
    /// (also known as custom fields) are always set to <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </para>
    /// </remarks>
    public Task<UpsertCustomerCustomAttributeResponse> UpsertCustomerCustomAttribute(UpsertCustomerCustomAttributeOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/{customer_id}/custom-attributes/{key}"),
            [new TemplateParam("customer_id", request.CustomerId), new TemplateParam("key", request.Key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpsertCustomerCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}

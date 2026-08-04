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
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkUpsertCustomerCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<BulkUpsertCustomerCustomAttributesResponse> BulkUpsertCustomerCustomAttributes(BulkUpsertCustomerCustomAttributesRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/custom-attributes/bulk-upsert"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BulkUpsertCustomerCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// CreateCustomerCustomAttributeDefinition
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateCustomerCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<CreateCustomerCustomAttributeDefinitionResponse> CreateCustomerCustomAttributeDefinition(CreateCustomerCustomAttributeDefinitionRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/custom-attribute-definitions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateCustomerCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// DeleteCustomerCustomAttribute
    /// </summary>
    /// <param name="customerId">The ID of the target <see href="entity:Customer">customer profile</see>.</param>
    /// <param name="key">The key of the custom attribute to delete. This key must match the <c>key</c> of a custom attribute definition in the Square seller account. If the requesting application is not the definition owner, you must use the qualified key.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteCustomerCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a <see href="entity:CustomAttribute">custom attribute</see> associated with a customer profile.
    /// <para>
    /// To delete a custom attribute owned by another application, the <c>visibility</c> setting must be
    /// <c>VISIBILITY_READ_WRITE_VALUES</c>. Note that seller-defined custom attributes
    /// (also known as custom fields) are always set to <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </para>
    /// </remarks>
    public Task<DeleteCustomerCustomAttributeResponse> DeleteCustomerCustomAttribute(string customerId,
        string key,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/{customer_id}/custom-attributes/{key}"),
            [new TemplateParam("customer_id", customerId), new TemplateParam("key", key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteCustomerCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// DeleteCustomerCustomAttributeDefinition
    /// </summary>
    /// <param name="key">The key of the custom attribute definition to delete.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteCustomerCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<DeleteCustomerCustomAttributeDefinitionResponse> DeleteCustomerCustomAttributeDefinition(string key,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteCustomerCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListCustomerCustomAttributeDefinitions
    /// </summary>
    /// <param name="limit">The maximum number of results to return in a single paged response. This limit is advisory. The response might contain more or fewer results. The minimum value is 1 and the maximum value is 100. The default value is 20. For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.</param>
    /// <param name="cursor">The cursor returned in the paged response from the previous call to this endpoint. Provide this cursor to retrieve the next page of results for your original request. For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCustomerCustomAttributeDefinitionsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the customer-related <see href="entity:CustomAttributeDefinition">custom attribute definitions</see> that belong to a Square seller account.
    /// <para>
    /// When all response pages are retrieved, the results include all custom attribute definitions
    /// that are visible to the requesting application, including those that are created by other
    /// applications and set to <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>. Note that
    /// seller-defined custom attributes (also known as custom fields) are always set to <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </para>
    /// </remarks>
    public Task<ListCustomerCustomAttributeDefinitionsResponse> ListCustomerCustomAttributeDefinitions(int? limit,
        string? cursor,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/custom-attribute-definitions"),
            [],
            [new Param("limit", limit), new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCustomerCustomAttributeDefinitionsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListCustomerCustomAttributes
    /// </summary>
    /// <param name="customerId">The ID of the target <see href="entity:Customer">customer profile</see>.</param>
    /// <param name="limit">The maximum number of results to return in a single paged response. This limit is advisory. The response might contain more or fewer results. The minimum value is 1 and the maximum value is 100. The default value is 20. For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.</param>
    /// <param name="cursor">The cursor returned in the paged response from the previous call to this endpoint. Provide this cursor to retrieve the next page of results for your original request. For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.</param>
    /// <param name="withDefinitions">Indicates whether to return the <see href="entity:CustomAttributeDefinition">custom attribute definition</see> in the <c>definition</c> field of each custom attribute. Set this parameter to <c>true</c> to get the name and description of each custom attribute, information about the data type, or other definition details. The default value is <c>false</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCustomerCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<ListCustomerCustomAttributesResponse> ListCustomerCustomAttributes(string customerId,
        int? limit,
        string? cursor,
        bool? withDefinitions = false,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/{customer_id}/custom-attributes"),
            [new TemplateParam("customer_id", customerId)],
            [new Param("limit", limit), new Param("cursor", cursor), new Param("with_definitions", withDefinitions)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCustomerCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveCustomerCustomAttribute
    /// </summary>
    /// <param name="customerId">The ID of the target <see href="entity:Customer">customer profile</see>.</param>
    /// <param name="key">The key of the custom attribute to retrieve. This key must match the <c>key</c> of a custom attribute definition in the Square seller account. If the requesting application is not the definition owner, you must use the qualified key.</param>
    /// <param name="version">The current version of the custom attribute, which is used for strongly consistent reads to guarantee that you receive the most up-to-date data. When included in the request, Square returns the specified version or a higher version if one exists. If the specified version is higher than the current version, Square returns a <c>BAD_REQUEST</c> error.</param>
    /// <param name="withDefinition">Indicates whether to return the <see href="entity:CustomAttributeDefinition">custom attribute definition</see> in the <c>definition</c> field of the custom attribute. Set this parameter to <c>true</c> to get the name and description of the custom attribute, information about the data type, or other definition details. The default value is <c>false</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveCustomerCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<RetrieveCustomerCustomAttributeResponse> RetrieveCustomerCustomAttribute(string customerId,
        string key,
        int? version,
        bool? withDefinition = false,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/{customer_id}/custom-attributes/{key}"),
            [new TemplateParam("customer_id", customerId), new TemplateParam("key", key)],
            [new Param("with_definition", withDefinition), new Param("version", version)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveCustomerCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveCustomerCustomAttributeDefinition
    /// </summary>
    /// <param name="key">The key of the custom attribute definition to retrieve. If the requesting application is not the definition owner, you must use the qualified key.</param>
    /// <param name="version">The current version of the custom attribute definition, which is used for strongly consistent reads to guarantee that you receive the most up-to-date data. When included in the request, Square returns the specified version or a higher version if one exists. If the specified version is higher than the current version, Square returns a <c>BAD_REQUEST</c> error.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveCustomerCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a customer-related <see href="entity:CustomAttributeDefinition">custom attribute definition</see> from a Square seller account.
    /// <para>
    /// To retrieve a custom attribute definition created by another application, the <c>visibility</c>
    /// setting must be <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>. Note that seller-defined custom attributes
    /// (also known as custom fields) are always set to <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </para>
    /// </remarks>
    public Task<RetrieveCustomerCustomAttributeDefinitionResponse> RetrieveCustomerCustomAttributeDefinition(string key,
        int? version,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", key)],
            [new Param("version", version)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveCustomerCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// UpdateCustomerCustomAttributeDefinition
    /// </summary>
    /// <param name="key">The key of the custom attribute definition to update.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateCustomerCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<UpdateCustomerCustomAttributeDefinitionResponse> UpdateCustomerCustomAttributeDefinition(string key,
        UpdateCustomerCustomAttributeDefinitionRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateCustomerCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// UpsertCustomerCustomAttribute
    /// </summary>
    /// <param name="customerId">The ID of the target <see href="entity:Customer">customer profile</see>.</param>
    /// <param name="key">The key of the custom attribute to create or update. This key must match the <c>key</c> of a custom attribute definition in the Square seller account. If the requesting application is not the definition owner, you must use the qualified key.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpsertCustomerCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<UpsertCustomerCustomAttributeResponse> UpsertCustomerCustomAttribute(string customerId,
        string key,
        UpsertCustomerCustomAttributeRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/{customer_id}/custom-attributes/{key}"),
            [new TemplateParam("customer_id", customerId), new TemplateParam("key", key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UpsertCustomerCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);
}

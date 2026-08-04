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

public sealed class BookingCustomAttributes
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal BookingCustomAttributes(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// BulkDeleteBookingCustomAttributes
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkDeleteBookingCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Bulk deletes bookings custom attributes.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_WRITE</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_WRITE</c> and <c>APPOINTMENTS_WRITE</c> for the OAuth scope.
    /// </para>
    /// <para>
    /// For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
    /// or *Appointments Premium*.
    /// </para>
    /// </remarks>
    public Task<BulkDeleteBookingCustomAttributesResponse> BulkDeleteBookingCustomAttributes(BulkDeleteBookingCustomAttributesRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/custom-attributes/bulk-delete"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BulkDeleteBookingCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// BulkUpsertBookingCustomAttributes
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkUpsertBookingCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Bulk upserts bookings custom attributes.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_WRITE</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_WRITE</c> and <c>APPOINTMENTS_WRITE</c> for the OAuth scope.
    /// </para>
    /// <para>
    /// For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
    /// or *Appointments Premium*.
    /// </para>
    /// </remarks>
    public Task<BulkUpsertBookingCustomAttributesResponse> BulkUpsertBookingCustomAttributes(BulkUpsertBookingCustomAttributesRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/custom-attributes/bulk-upsert"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BulkUpsertBookingCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// CreateBookingCustomAttributeDefinition
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateBookingCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a bookings custom attribute definition.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_WRITE</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_WRITE</c> and <c>APPOINTMENTS_WRITE</c> for the OAuth scope.
    /// </para>
    /// <para>
    /// For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
    /// or *Appointments Premium*.
    /// </para>
    /// </remarks>
    public Task<CreateBookingCustomAttributeDefinitionResponse> CreateBookingCustomAttributeDefinition(CreateBookingCustomAttributeDefinitionRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/custom-attribute-definitions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateBookingCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// DeleteBookingCustomAttribute
    /// </summary>
    /// <param name="bookingId">The ID of the target <see href="entity:Booking">booking</see>.</param>
    /// <param name="key">The key of the custom attribute to delete. This key must match the <c>key</c> of a custom attribute definition in the Square seller account. If the requesting application is not the definition owner, you must use the qualified key.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteBookingCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a bookings custom attribute.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_WRITE</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_WRITE</c> and <c>APPOINTMENTS_WRITE</c> for the OAuth scope.
    /// </para>
    /// <para>
    /// For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
    /// or *Appointments Premium*.
    /// </para>
    /// </remarks>
    public Task<DeleteBookingCustomAttributeResponse> DeleteBookingCustomAttribute(string bookingId,
        string key,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/{booking_id}/custom-attributes/{key}"),
            [new TemplateParam("booking_id", bookingId), new TemplateParam("key", key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteBookingCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// DeleteBookingCustomAttributeDefinition
    /// </summary>
    /// <param name="key">The key of the custom attribute definition to delete.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteBookingCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a bookings custom attribute definition.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_WRITE</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_WRITE</c> and <c>APPOINTMENTS_WRITE</c> for the OAuth scope.
    /// </para>
    /// <para>
    /// For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
    /// or *Appointments Premium*.
    /// </para>
    /// </remarks>
    public Task<DeleteBookingCustomAttributeDefinitionResponse> DeleteBookingCustomAttributeDefinition(string key,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteBookingCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListBookingCustomAttributeDefinitions
    /// </summary>
    /// <param name="limit">The maximum number of results to return in a single paged response. This limit is advisory. The response might contain more or fewer results. The minimum value is 1 and the maximum value is 100. The default value is 20. For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.</param>
    /// <param name="cursor">The cursor returned in the paged response from the previous call to this endpoint. Provide this cursor to retrieve the next page of results for your original request. For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListBookingCustomAttributeDefinitionsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get all bookings custom attribute definitions.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_READ</c> and <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// </para>
    /// </remarks>
    public Task<ListBookingCustomAttributeDefinitionsResponse> ListBookingCustomAttributeDefinitions(int? limit,
        string? cursor,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/custom-attribute-definitions"),
            [],
            [new Param("limit", limit), new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListBookingCustomAttributeDefinitionsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListBookingCustomAttributes
    /// </summary>
    /// <param name="bookingId">The ID of the target <see href="entity:Booking">booking</see>.</param>
    /// <param name="limit">The maximum number of results to return in a single paged response. This limit is advisory. The response might contain more or fewer results. The minimum value is 1 and the maximum value is 100. The default value is 20. For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.</param>
    /// <param name="cursor">The cursor returned in the paged response from the previous call to this endpoint. Provide this cursor to retrieve the next page of results for your original request. For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.</param>
    /// <param name="withDefinitions">Indicates whether to return the <see href="entity:CustomAttributeDefinition">custom attribute definition</see> in the <c>definition</c> field of each custom attribute. Set this parameter to <c>true</c> to get the name and description of each custom attribute, information about the data type, or other definition details. The default value is <c>false</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListBookingCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists a booking's custom attributes.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_READ</c> and <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// </para>
    /// </remarks>
    public Task<ListBookingCustomAttributesResponse> ListBookingCustomAttributes(string bookingId,
        int? limit,
        string? cursor,
        bool? withDefinitions = false,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/{booking_id}/custom-attributes"),
            [new TemplateParam("booking_id", bookingId)],
            [new Param("limit", limit), new Param("cursor", cursor), new Param("with_definitions", withDefinitions)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListBookingCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveBookingCustomAttribute
    /// </summary>
    /// <param name="bookingId">The ID of the target <see href="entity:Booking">booking</see>.</param>
    /// <param name="key">The key of the custom attribute to retrieve. This key must match the <c>key</c> of a custom attribute definition in the Square seller account. If the requesting application is not the definition owner, you must use the qualified key.</param>
    /// <param name="version">The current version of the custom attribute, which is used for strongly consistent reads to guarantee that you receive the most up-to-date data. When included in the request, Square returns the specified version or a higher version if one exists. If the specified version is higher than the current version, Square returns a <c>BAD_REQUEST</c> error.</param>
    /// <param name="withDefinition">Indicates whether to return the <see href="entity:CustomAttributeDefinition">custom attribute definition</see> in the <c>definition</c> field of the custom attribute. Set this parameter to <c>true</c> to get the name and description of the custom attribute, information about the data type, or other definition details. The default value is <c>false</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveBookingCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a bookings custom attribute.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_READ</c> and <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// </para>
    /// </remarks>
    public Task<RetrieveBookingCustomAttributeResponse> RetrieveBookingCustomAttribute(string bookingId,
        string key,
        int? version,
        bool? withDefinition = false,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/{booking_id}/custom-attributes/{key}"),
            [new TemplateParam("booking_id", bookingId), new TemplateParam("key", key)],
            [new Param("with_definition", withDefinition), new Param("version", version)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveBookingCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveBookingCustomAttributeDefinition
    /// </summary>
    /// <param name="key">The key of the custom attribute definition to retrieve. If the requesting application is not the definition owner, you must use the qualified key.</param>
    /// <param name="version">The current version of the custom attribute definition, which is used for strongly consistent reads to guarantee that you receive the most up-to-date data. When included in the request, Square returns the specified version or a higher version if one exists. If the specified version is higher than the current version, Square returns a <c>BAD_REQUEST</c> error.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveBookingCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a bookings custom attribute definition.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_READ</c> and <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// </para>
    /// </remarks>
    public Task<RetrieveBookingCustomAttributeDefinitionResponse> RetrieveBookingCustomAttributeDefinition(string key,
        int? version,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", key)],
            [new Param("version", version)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveBookingCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// UpdateBookingCustomAttributeDefinition
    /// </summary>
    /// <param name="key">The key of the custom attribute definition to update.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateBookingCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a bookings custom attribute definition.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_WRITE</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_WRITE</c> and <c>APPOINTMENTS_WRITE</c> for the OAuth scope.
    /// </para>
    /// <para>
    /// For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
    /// or *Appointments Premium*.
    /// </para>
    /// </remarks>
    public Task<UpdateBookingCustomAttributeDefinitionResponse> UpdateBookingCustomAttributeDefinition(string key,
        UpdateBookingCustomAttributeDefinitionRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateBookingCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// UpsertBookingCustomAttribute
    /// </summary>
    /// <param name="bookingId">The ID of the target <see href="entity:Booking">booking</see>.</param>
    /// <param name="key">The key of the custom attribute to create or update. This key must match the <c>key</c> of a custom attribute definition in the Square seller account. If the requesting application is not the definition owner, you must use the qualified key.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpsertBookingCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Upserts a bookings custom attribute.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_WRITE</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_WRITE</c> and <c>APPOINTMENTS_WRITE</c> for the OAuth scope.
    /// </para>
    /// <para>
    /// For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
    /// or *Appointments Premium*.
    /// </para>
    /// </remarks>
    public Task<UpsertBookingCustomAttributeResponse> UpsertBookingCustomAttribute(string bookingId,
        string key,
        UpsertBookingCustomAttributeRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/{booking_id}/custom-attributes/{key}"),
            [new TemplateParam("booking_id", bookingId), new TemplateParam("key", key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpsertBookingCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);
}

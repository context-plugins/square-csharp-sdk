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
using Square.Requests.BookingCustomAttributes;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkDeleteBookingCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<BulkDeleteBookingCustomAttributesResponse> BulkDeleteBookingCustomAttributes(BulkDeleteBookingCustomAttributesOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/custom-attributes/bulk-delete"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BulkDeleteBookingCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// BulkUpsertBookingCustomAttributes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkUpsertBookingCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<BulkUpsertBookingCustomAttributesResponse> BulkUpsertBookingCustomAttributes(BulkUpsertBookingCustomAttributesOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/custom-attributes/bulk-upsert"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BulkUpsertBookingCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CreateBookingCustomAttributeDefinition
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateBookingCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<CreateBookingCustomAttributeDefinitionResponse> CreateBookingCustomAttributeDefinition(CreateBookingCustomAttributeDefinitionOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/custom-attribute-definitions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateBookingCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeleteBookingCustomAttribute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteBookingCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<DeleteBookingCustomAttributeResponse> DeleteBookingCustomAttribute(DeleteBookingCustomAttributeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/{booking_id}/custom-attributes/{key}"),
            [new TemplateParam("booking_id", request.BookingId), new TemplateParam("key", request.Key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteBookingCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeleteBookingCustomAttributeDefinition
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteBookingCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<DeleteBookingCustomAttributeDefinitionResponse> DeleteBookingCustomAttributeDefinition(DeleteBookingCustomAttributeDefinitionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", request.Key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteBookingCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListBookingCustomAttributeDefinitions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListBookingCustomAttributeDefinitionsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get all bookings custom attribute definitions.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_READ</c> and <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// </para>
    /// </remarks>
    public Task<ListBookingCustomAttributeDefinitionsResponse> ListBookingCustomAttributeDefinitions(ListBookingCustomAttributeDefinitionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/custom-attribute-definitions"),
            [],
            [new Param("limit", request.Limit), new Param("cursor", request.Cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListBookingCustomAttributeDefinitionsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListBookingCustomAttributes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListBookingCustomAttributesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists a booking's custom attributes.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_READ</c> and <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// </para>
    /// </remarks>
    public Task<ListBookingCustomAttributesResponse> ListBookingCustomAttributes(ListBookingCustomAttributesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/{booking_id}/custom-attributes"),
            [new TemplateParam("booking_id", request.BookingId)],
            [
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
                new Param("with_definitions", request.WithDefinitions),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListBookingCustomAttributesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveBookingCustomAttribute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveBookingCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a bookings custom attribute.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_READ</c> and <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// </para>
    /// </remarks>
    public Task<RetrieveBookingCustomAttributeResponse> RetrieveBookingCustomAttribute(RetrieveBookingCustomAttributeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/{booking_id}/custom-attributes/{key}"),
            [new TemplateParam("booking_id", request.BookingId), new TemplateParam("key", request.Key)],
            [new Param("with_definition", request.WithDefinition), new Param("version", request.Version)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveBookingCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveBookingCustomAttributeDefinition
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveBookingCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a bookings custom attribute definition.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_READ</c> and <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// </para>
    /// </remarks>
    public Task<RetrieveBookingCustomAttributeDefinitionResponse> RetrieveBookingCustomAttributeDefinition(RetrieveBookingCustomAttributeDefinitionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", request.Key)],
            [new Param("version", request.Version)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveBookingCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpdateBookingCustomAttributeDefinition
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateBookingCustomAttributeDefinitionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<UpdateBookingCustomAttributeDefinitionResponse> UpdateBookingCustomAttributeDefinition(UpdateBookingCustomAttributeDefinitionOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/custom-attribute-definitions/{key}"),
            [new TemplateParam("key", request.Key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateBookingCustomAttributeDefinitionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpsertBookingCustomAttribute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpsertBookingCustomAttributeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<UpsertBookingCustomAttributeResponse> UpsertBookingCustomAttribute(UpsertBookingCustomAttributeOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/{booking_id}/custom-attributes/{key}"),
            [new TemplateParam("booking_id", request.BookingId), new TemplateParam("key", request.Key)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpsertBookingCustomAttributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}

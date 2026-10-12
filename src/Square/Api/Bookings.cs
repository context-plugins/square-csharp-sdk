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
using Square.Requests.Bookings;

namespace Square.Api;

public sealed class Bookings
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Bookings(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// BulkRetrieveBookings
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkRetrieveBookingsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Bulk-Retrieves a list of bookings by booking IDs.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_READ</c> and <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// </para>
    /// </remarks>
    public Task<BulkRetrieveBookingsResponse> BulkRetrieveBookings(BulkRetrieveBookingsOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/bulk-retrieve"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BulkRetrieveBookingsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// BulkRetrieveTeamMemberBookingProfiles
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkRetrieveTeamMemberBookingProfilesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves one or more team members' booking profiles.
    /// </remarks>
    public Task<BulkRetrieveTeamMemberBookingProfilesResponse> BulkRetrieveTeamMemberBookingProfiles(BulkRetrieveTeamMemberBookingProfilesOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/team-member-booking-profiles/bulk-retrieve"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BulkRetrieveTeamMemberBookingProfilesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CancelBooking
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CancelBookingResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels an existing booking.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_WRITE</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_WRITE</c> and <c>APPOINTMENTS_WRITE</c> for the OAuth scope.
    /// </para>
    /// <para>
    /// For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
    /// or *Appointments Premium*.
    /// </para>
    /// </remarks>
    public Task<CancelBookingResponse> CancelBooking(CancelBookingOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/{booking_id}/cancel"),
            [new TemplateParam("booking_id", request.BookingId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CancelBookingResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CreateBooking
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateBookingResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a booking.
    /// <para>
    /// The required input must include the following:
    /// - <c>Booking.location_id</c>
    /// - <c>Booking.start_at</c>
    /// - <c>Booking.AppointmentSegment.team_member_id</c>
    /// - <c>Booking.AppointmentSegment.service_variation_id</c>
    /// - <c>Booking.AppointmentSegment.service_variation_version</c>
    /// </para>
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_WRITE</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_WRITE</c> and <c>APPOINTMENTS_WRITE</c> for the OAuth scope.
    /// </para>
    /// <para>
    /// For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
    /// or *Appointments Premium*.
    /// </para>
    /// </remarks>
    public Task<CreateBookingResponse> CreateBooking(CreateBookingOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateBookingResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListBookings
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListBookingsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve a collection of bookings.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_READ</c> and <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// </para>
    /// </remarks>
    public Task<ListBookingsResponse> ListBookings(ListBookingsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings"),
            [],
            [
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
                new Param("customer_id", request.CustomerId),
                new Param("team_member_id", request.TeamMemberId),
                new Param("location_id", request.LocationId),
                new Param("start_at_min", request.StartAtMin),
                new Param("start_at_max", request.StartAtMax),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListBookingsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListLocationBookingProfiles
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListLocationBookingProfilesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists location booking profiles of a seller.
    /// </remarks>
    public Task<ListLocationBookingProfilesResponse> ListLocationBookingProfiles(ListLocationBookingProfilesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/location-booking-profiles"),
            [],
            [new Param("limit", request.Limit), new Param("cursor", request.Cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListLocationBookingProfilesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListTeamMemberBookingProfiles
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListTeamMemberBookingProfilesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists booking profiles for team members.
    /// </remarks>
    public Task<ListTeamMemberBookingProfilesResponse> ListTeamMemberBookingProfiles(ListTeamMemberBookingProfilesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/team-member-booking-profiles"),
            [],
            [
                new Param("bookable_only", request.BookableOnly),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
                new Param("location_id", request.LocationId),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListTeamMemberBookingProfilesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveBooking
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveBookingResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a booking.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_READ</c> and <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// </para>
    /// </remarks>
    public Task<RetrieveBookingResponse> RetrieveBooking(RetrieveBookingRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/{booking_id}"),
            [new TemplateParam("booking_id", request.BookingId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveBookingResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveBusinessBookingProfile
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveBusinessBookingProfileResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a seller's booking profile.
    /// </remarks>
    public Task<RetrieveBusinessBookingProfileResponse> RetrieveBusinessBookingProfile(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/business-booking-profile"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveBusinessBookingProfileResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveLocationBookingProfile
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveLocationBookingProfileResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a seller's location booking profile.
    /// </remarks>
    public Task<RetrieveLocationBookingProfileResponse> RetrieveLocationBookingProfile(RetrieveLocationBookingProfileRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/location-booking-profiles/{location_id}"),
            [new TemplateParam("location_id", request.LocationId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveLocationBookingProfileResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveTeamMemberBookingProfile
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveTeamMemberBookingProfileResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a team member's booking profile.
    /// </remarks>
    public Task<RetrieveTeamMemberBookingProfileResponse> RetrieveTeamMemberBookingProfile(RetrieveTeamMemberBookingProfileRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/team-member-booking-profiles/{team_member_id}"),
            [new TemplateParam("team_member_id", request.TeamMemberId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveTeamMemberBookingProfileResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// SearchAvailability
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchAvailabilityResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches for availabilities for booking.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_READ</c> and <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// </para>
    /// </remarks>
    public Task<SearchAvailabilityResponse> SearchAvailability(SearchAvailabilityOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/availability/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SearchAvailabilityResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpdateBooking
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateBookingResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a booking.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_WRITE</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_WRITE</c> and <c>APPOINTMENTS_WRITE</c> for the OAuth scope.
    /// </para>
    /// <para>
    /// For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
    /// or *Appointments Premium*.
    /// </para>
    /// </remarks>
    public Task<UpdateBookingResponse> UpdateBooking(UpdateBookingOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/bookings/{booking_id}"),
            [new TemplateParam("booking_id", request.BookingId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateBookingResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}

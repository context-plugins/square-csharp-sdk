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
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkRetrieveBookingsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Bulk-Retrieves a list of bookings by booking IDs.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_READ</c> and <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// </para>
    /// </remarks>
    public Task<BulkRetrieveBookingsResponse> BulkRetrieveBookings(BulkRetrieveBookingsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/bulk-retrieve"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BulkRetrieveBookingsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// BulkRetrieveTeamMemberBookingProfiles
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkRetrieveTeamMemberBookingProfilesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves one or more team members' booking profiles.
    /// </remarks>
    public Task<BulkRetrieveTeamMemberBookingProfilesResponse> BulkRetrieveTeamMemberBookingProfiles(BulkRetrieveTeamMemberBookingProfilesRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/team-member-booking-profiles/bulk-retrieve"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BulkRetrieveTeamMemberBookingProfilesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// CancelBooking
    /// </summary>
    /// <param name="bookingId">The ID of the <see href="entity:Booking">Booking</see> object representing the to-be-cancelled booking.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CancelBookingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<CancelBookingResponse> CancelBooking(string bookingId,
        CancelBookingRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/{booking_id}/cancel"),
            [new TemplateParam("booking_id", bookingId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CancelBookingResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// CreateBooking
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateBookingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<CreateBookingResponse> CreateBooking(CreateBookingRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateBookingResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListBookings
    /// </summary>
    /// <param name="limit">The maximum number of results per page to return in a paged response.</param>
    /// <param name="cursor">The pagination cursor from the preceding response to return the next page of the results. Do not set this when retrieving the first page of the results.</param>
    /// <param name="customerId">The <see href="entity:Customer">customer</see> for whom to retrieve bookings. If this is not set, bookings for all customers are retrieved.</param>
    /// <param name="teamMemberId">The team member for whom to retrieve bookings. If this is not set, bookings of all members are retrieved.</param>
    /// <param name="locationId">The location for which to retrieve bookings. If this is not set, all locations' bookings are retrieved.</param>
    /// <param name="startAtMin">The RFC 3339 timestamp specifying the earliest of the start time. If this is not set, the current time is used.</param>
    /// <param name="startAtMax">The RFC 3339 timestamp specifying the latest of the start time. If this is not set, the time of 31 days after <c>start_at_min</c> is used.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListBookingsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve a collection of bookings.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_READ</c> and <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// </para>
    /// </remarks>
    public Task<ListBookingsResponse> ListBookings(int? limit,
        string? cursor,
        string? customerId,
        string? teamMemberId,
        string? locationId,
        string? startAtMin,
        string? startAtMax,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings"),
            [],
            [new Param("limit", limit),
                new Param("cursor", cursor),
                new Param("customer_id", customerId),
                new Param("team_member_id", teamMemberId),
                new Param("location_id", locationId),
                new Param("start_at_min", startAtMin),
                new Param("start_at_max", startAtMax)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListBookingsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListLocationBookingProfiles
    /// </summary>
    /// <param name="limit">The maximum number of results to return in a paged response.</param>
    /// <param name="cursor">The pagination cursor from the preceding response to return the next page of the results. Do not set this when retrieving the first page of the results.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListLocationBookingProfilesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists location booking profiles of a seller.
    /// </remarks>
    public Task<ListLocationBookingProfilesResponse> ListLocationBookingProfiles(int? limit,
        string? cursor,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/location-booking-profiles"),
            [],
            [new Param("limit", limit), new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListLocationBookingProfilesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListTeamMemberBookingProfiles
    /// </summary>
    /// <param name="limit">The maximum number of results to return in a paged response.</param>
    /// <param name="cursor">The pagination cursor from the preceding response to return the next page of the results. Do not set this when retrieving the first page of the results.</param>
    /// <param name="locationId">Indicates whether to include only team members enabled at the given location in the returned result.</param>
    /// <param name="bookableOnly">Indicates whether to include only bookable team members in the returned result (<c>true</c>) or not (<c>false</c>).</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListTeamMemberBookingProfilesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists booking profiles for team members.
    /// </remarks>
    public Task<ListTeamMemberBookingProfilesResponse> ListTeamMemberBookingProfiles(int? limit,
        string? cursor,
        string? locationId,
        bool? bookableOnly = false,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/team-member-booking-profiles"),
            [],
            [new Param("bookable_only", bookableOnly),
                new Param("limit", limit),
                new Param("cursor", cursor),
                new Param("location_id", locationId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListTeamMemberBookingProfilesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveBooking
    /// </summary>
    /// <param name="bookingId">The ID of the <see href="entity:Booking">Booking</see> object representing the to-be-retrieved booking.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveBookingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a booking.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_READ</c> and <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// </para>
    /// </remarks>
    public Task<RetrieveBookingResponse> RetrieveBooking(string bookingId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/{booking_id}"),
            [new TemplateParam("booking_id", bookingId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveBookingResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveBusinessBookingProfile
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveBusinessBookingProfileResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a seller's booking profile.
    /// </remarks>
    public Task<RetrieveBusinessBookingProfileResponse> RetrieveBusinessBookingProfile(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/business-booking-profile"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveBusinessBookingProfileResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveLocationBookingProfile
    /// </summary>
    /// <param name="locationId">The ID of the location to retrieve the booking profile.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveLocationBookingProfileResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a seller's location booking profile.
    /// </remarks>
    public Task<RetrieveLocationBookingProfileResponse> RetrieveLocationBookingProfile(string locationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/location-booking-profiles/{location_id}"),
            [new TemplateParam("location_id", locationId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveLocationBookingProfileResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveTeamMemberBookingProfile
    /// </summary>
    /// <param name="teamMemberId">The ID of the team member to retrieve.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveTeamMemberBookingProfileResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a team member's booking profile.
    /// </remarks>
    public Task<RetrieveTeamMemberBookingProfileResponse> RetrieveTeamMemberBookingProfile(string teamMemberId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/team-member-booking-profiles/{team_member_id}"),
            [new TemplateParam("team_member_id", teamMemberId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveTeamMemberBookingProfileResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// SearchAvailability
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchAvailabilityResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches for availabilities for booking.
    /// <para>
    /// To call this endpoint with buyer-level permissions, set <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// To call this endpoint with seller-level permissions, set <c>APPOINTMENTS_ALL_READ</c> and <c>APPOINTMENTS_READ</c> for the OAuth scope.
    /// </para>
    /// </remarks>
    public Task<SearchAvailabilityResponse> SearchAvailability(SearchAvailabilityRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/availability/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchAvailabilityResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// UpdateBooking
    /// </summary>
    /// <param name="bookingId">The ID of the <see href="entity:Booking">Booking</see> object representing the to-be-updated booking.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateBookingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<UpdateBookingResponse> UpdateBooking(string bookingId,
        UpdateBookingRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/{booking_id}"),
            [new TemplateParam("booking_id", bookingId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateBookingResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);
}

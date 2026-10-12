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
using Square.Requests.Labor;

namespace Square.Api;

public sealed class Labor
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Labor(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// BulkPublishScheduledShifts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkPublishScheduledShiftsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Publishes 1 - 100 scheduled shifts. This endpoint takes a map of individual publish
    /// requests and returns a map of responses. When a scheduled shift is published, Square keeps
    /// the <c>draft_shift_details</c> field as is and copies it to the <c>published_shift_details</c> field.
    /// <para>
    /// The minimum <c>start_at</c> and maximum <c>end_at</c> timestamps of all shifts in a
    /// <c>BulkPublishScheduledShifts</c> request must fall within a two-week period.
    /// </para>
    /// </remarks>
    public Task<BulkPublishScheduledShiftsResponse> BulkPublishScheduledShifts(BulkPublishScheduledShiftsOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/scheduled-shifts/bulk-publish"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BulkPublishScheduledShiftsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CreateBreakType
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateBreakTypeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new <c>BreakType</c>.
    /// <para>
    /// A <c>BreakType</c> is a template for creating <c>Break</c> objects.
    /// You must provide the following values in your request to this
    /// endpoint:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>location_id</c></description></item>
    ///   <item><description><c>break_name</c></description></item>
    ///   <item><description><c>expected_duration</c></description></item>
    ///   <item><description><c>is_paid</c></description></item>
    /// </list>
    /// <para>
    /// You can only have three <c>BreakType</c> instances per location. If you attempt to add a fourth
    /// <c>BreakType</c> for a location, an <c>INVALID_REQUEST_ERROR</c> "Exceeded limit of 3 breaks per location."
    /// is returned.
    /// </para>
    /// </remarks>
    public Task<CreateBreakTypeResponse> CreateBreakType(CreateBreakTypeOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/break-types"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateBreakTypeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CreateScheduledShift
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateScheduledShiftResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a scheduled shift by providing draft shift details such as job ID,
    /// team member assignment, and start and end times.
    /// <para>
    /// The following <c>draft_shift_details</c> fields are required:
    /// - <c>location_id</c>
    /// - <c>job_id</c>
    /// - <c>start_at</c>
    /// - <c>end_at</c>
    /// </para>
    /// </remarks>
    public Task<CreateScheduledShiftResponse> CreateScheduledShift(CreateScheduledShiftOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/scheduled-shifts"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateScheduledShiftResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CreateShift
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateShiftResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new <c>Shift</c>.
    /// <para>
    /// A <c>Shift</c> represents a complete workday for a single team member.
    /// You must provide the following values in your request to this
    /// endpoint:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>location_id</c></description></item>
    ///   <item><description><c>team_member_id</c></description></item>
    ///   <item><description><c>start_at</c></description></item>
    /// </list>
    /// <para>
    /// An attempt to create a new <c>Shift</c> can result in a <c>BAD_REQUEST</c> error when:
    /// - The <c>status</c> of the new <c>Shift</c> is <c>OPEN</c> and the team member has another
    /// shift with an <c>OPEN</c> status.
    /// - The <c>start_at</c> date is in the future.
    /// - The <c>start_at</c> or <c>end_at</c> date overlaps another shift for the same team member.
    /// - The <c>Break</c> instances are set in the request and a break <c>start_at</c>
    /// is before the <c>Shift.start_at</c>, a break <c>end_at</c> is after
    /// the <c>Shift.end_at</c>, or both.
    /// </para>
    /// </remarks>
    public Task<CreateShiftResponse> CreateShift(CreateShiftOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/shifts"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateShiftResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CreateTimecard
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateTimecardResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new <c>Timecard</c>.
    /// <para>
    /// A <c>Timecard</c> represents a complete workday for a single team member.
    /// You must provide the following values in your request to this
    /// endpoint:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>location_id</c></description></item>
    ///   <item><description><c>team_member_id</c></description></item>
    ///   <item><description><c>start_at</c></description></item>
    /// </list>
    /// <para>
    /// An attempt to create a new <c>Timecard</c> can result in a <c>BAD_REQUEST</c> error when:
    /// - The <c>status</c> of the new <c>Timecard</c> is <c>OPEN</c> and the team member has another
    /// timecard with an <c>OPEN</c> status.
    /// - The <c>start_at</c> date is in the future.
    /// - The <c>start_at</c> or <c>end_at</c> date overlaps another timecard for the same team member.
    /// - The <c>Break</c> instances are set in the request and a break <c>start_at</c>
    /// is before the <c>Timecard.start_at</c>, a break <c>end_at</c> is after
    /// the <c>Timecard.end_at</c>, or both.
    /// </para>
    /// </remarks>
    public Task<CreateTimecardResponse> CreateTimecard(CreateTimecardOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/timecards"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateTimecardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeleteBreakType
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteBreakTypeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes an existing <c>BreakType</c>.
    /// <para>
    /// A <c>BreakType</c> can be deleted even if it is referenced from a <c>Shift</c>.
    /// </para>
    /// </remarks>
    public Task<DeleteBreakTypeResponse> DeleteBreakType(DeleteBreakTypeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/break-types/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteBreakTypeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeleteShift
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteShiftResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a <c>Shift</c>.
    /// </remarks>
    public Task<DeleteShiftResponse> DeleteShift(DeleteShiftRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/shifts/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteShiftResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeleteTimecard
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteTimecardResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a <c>Timecard</c>.
    /// </remarks>
    public Task<DeleteTimecardResponse> DeleteTimecard(DeleteTimecardRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/timecards/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteTimecardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// GetBreakType
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetBreakTypeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a single <c>BreakType</c> specified by <c>id</c>.
    /// </remarks>
    public Task<GetBreakTypeResponse> GetBreakType(GetBreakTypeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/break-types/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetBreakTypeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// GetEmployeeWage
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetEmployeeWageResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a single <c>EmployeeWage</c> specified by <c>id</c>.
    /// </remarks>
    public Task<GetEmployeeWageResponse> GetEmployeeWage(GetEmployeeWageRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/employee-wages/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetEmployeeWageResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// GetShift
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetShiftResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a single <c>Shift</c> specified by <c>id</c>.
    /// </remarks>
    public Task<GetShiftResponse> GetShift(GetShiftRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/shifts/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetShiftResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// GetTeamMemberWage
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetTeamMemberWageResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a single <c>TeamMemberWage</c> specified by <c>id</c>.
    /// </remarks>
    public Task<GetTeamMemberWageResponse> GetTeamMemberWage(GetTeamMemberWageRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/team-member-wages/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetTeamMemberWageResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListBreakTypes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListBreakTypesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of <c>BreakType</c> instances for a business.
    /// </remarks>
    public Task<ListBreakTypesResponse> ListBreakTypes(ListBreakTypesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/break-types"),
            [],
            [
                new Param("location_id", request.LocationId),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListBreakTypesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListEmployeeWages
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListEmployeeWagesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of <c>EmployeeWage</c> instances for a business.
    /// </remarks>
    public Task<ListEmployeeWagesResponse> ListEmployeeWages(ListEmployeeWagesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/employee-wages"),
            [],
            [
                new Param("employee_id", request.EmployeeId),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListEmployeeWagesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListTeamMemberWages
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListTeamMemberWagesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of <c>TeamMemberWage</c> instances for a business.
    /// </remarks>
    public Task<ListTeamMemberWagesResponse> ListTeamMemberWages(ListTeamMemberWagesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/team-member-wages"),
            [],
            [
                new Param("team_member_id", request.TeamMemberId),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListTeamMemberWagesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListWorkweekConfigs
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListWorkweekConfigsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of <c>WorkweekConfig</c> instances for a business.
    /// </remarks>
    public Task<ListWorkweekConfigsResponse> ListWorkweekConfigs(ListWorkweekConfigsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/workweek-configs"),
            [],
            [new Param("limit", request.Limit), new Param("cursor", request.Cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListWorkweekConfigsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// PublishScheduledShift
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PublishScheduledShiftResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Publishes a scheduled shift. When a scheduled shift is published, Square keeps the
    /// <c>draft_shift_details</c> field as is and copies it to the <c>published_shift_details</c> field.
    /// </remarks>
    public Task<PublishScheduledShiftResponse> PublishScheduledShift(PublishScheduledShiftOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/scheduled-shifts/{id}/publish"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PublishScheduledShiftResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveScheduledShift
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveScheduledShiftResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a scheduled shift by ID.
    /// </remarks>
    public Task<RetrieveScheduledShiftResponse> RetrieveScheduledShift(RetrieveScheduledShiftRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/scheduled-shifts/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveScheduledShiftResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveTimecard
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveTimecardResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a single <c>Timecard</c> specified by <c>id</c>.
    /// </remarks>
    public Task<RetrieveTimecardResponse> RetrieveTimecard(RetrieveTimecardRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/timecards/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveTimecardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// SearchScheduledShifts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchScheduledShiftsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of scheduled shifts, with optional filter and sort settings.
    /// By default, results are sorted by <c>start_at</c> in ascending order.
    /// </remarks>
    public Task<SearchScheduledShiftsResponse> SearchScheduledShifts(SearchScheduledShiftsOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/scheduled-shifts/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SearchScheduledShiftsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// SearchShifts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchShiftsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of <c>Shift</c> records for a business.
    /// The list to be returned can be filtered by:
    /// - Location IDs
    /// - Team member IDs
    /// - Shift status (<c>OPEN</c> or <c>CLOSED</c>)
    /// - Shift start
    /// - Shift end
    /// - Workday details
    /// <para>
    /// The list can be sorted by:
    /// - <c>START_AT</c>
    /// - <c>END_AT</c>
    /// - <c>CREATED_AT</c>
    /// - <c>UPDATED_AT</c>
    /// </para>
    /// </remarks>
    public Task<SearchShiftsResponse> SearchShifts(SearchShiftsOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/shifts/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SearchShiftsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// SearchTimecards
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchTimecardsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of <c>Timecard</c> records for a business.
    /// The list to be returned can be filtered by:
    /// - Location IDs
    /// - Team member IDs
    /// - Timecard status (<c>OPEN</c> or <c>CLOSED</c>)
    /// - Timecard start
    /// - Timecard end
    /// - Workday details
    /// <para>
    /// The list can be sorted by:
    /// - <c>START_AT</c>
    /// - <c>END_AT</c>
    /// - <c>CREATED_AT</c>
    /// - <c>UPDATED_AT</c>
    /// </para>
    /// </remarks>
    public Task<SearchTimecardsResponse> SearchTimecards(SearchTimecardsOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/timecards/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SearchTimecardsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpdateBreakType
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateBreakTypeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates an existing <c>BreakType</c>.
    /// </remarks>
    public Task<UpdateBreakTypeResponse> UpdateBreakType(UpdateBreakTypeOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/break-types/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateBreakTypeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpdateScheduledShift
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateScheduledShiftResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the draft shift details for a scheduled shift. This endpoint supports
    /// sparse updates, so only new, changed, or removed fields are required in the request.
    /// You must publish the shift to make updates public.
    /// <para>
    /// You can make the following updates to <c>draft_shift_details</c>:
    /// - Change the <c>location_id</c>, <c>job_id</c>, <c>start_at</c>, and <c>end_at</c> fields.
    /// - Add, change, or clear the <c>team_member_id</c> and <c>notes</c> fields. To clear these fields,
    /// set the value to null.
    /// - Change the <c>is_deleted</c> field. To delete a scheduled shift, set <c>is_deleted</c> to true
    /// and then publish the shift.
    /// </para>
    /// </remarks>
    public Task<UpdateScheduledShiftResponse> UpdateScheduledShift(UpdateScheduledShiftOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/scheduled-shifts/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateScheduledShiftResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpdateShift
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateShiftResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates an existing <c>Shift</c>.
    /// <para>
    /// When adding a <c>Break</c> to a <c>Shift</c>, any earlier <c>Break</c> instances in the <c>Shift</c> have
    /// the <c>end_at</c> property set to a valid RFC-3339 datetime string.
    /// </para>
    /// <para>
    /// When closing a <c>Shift</c>, all <c>Break</c> instances in the <c>Shift</c> must be complete with <c>end_at</c>
    /// set on each <c>Break</c>.
    /// </para>
    /// </remarks>
    public Task<UpdateShiftResponse> UpdateShift(UpdateShiftOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/shifts/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateShiftResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpdateTimecard
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateTimecardResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates an existing <c>Timecard</c>.
    /// <para>
    /// When adding a <c>Break</c> to a <c>Timecard</c>, any earlier <c>Break</c> instances in the <c>Timecard</c> have
    /// the <c>end_at</c> property set to a valid RFC-3339 datetime string.
    /// </para>
    /// <para>
    /// When closing a <c>Timecard</c>, all <c>Break</c> instances in the <c>Timecard</c> must be complete with <c>end_at</c>
    /// set on each <c>Break</c>.
    /// </para>
    /// </remarks>
    public Task<UpdateTimecardResponse> UpdateTimecard(UpdateTimecardOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/timecards/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateTimecardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpdateWorkweekConfig
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateWorkweekConfigResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a <c>WorkweekConfig</c>.
    /// </remarks>
    public Task<UpdateWorkweekConfigResponse> UpdateWorkweekConfig(UpdateWorkweekConfigOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/labor/workweek-configs/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateWorkweekConfigResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}

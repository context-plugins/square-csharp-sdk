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

public sealed class Team
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Team(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// BulkCreateTeamMembers
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkCreateTeamMembersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates multiple <c>TeamMember</c> objects. The created <c>TeamMember</c> objects are returned on successful creates.
    /// This process is non-transactional and processes as much of the request as possible. If one of the creates in
    /// the request cannot be successfully processed, the request is not marked as failed, but the body of the response
    /// contains explicit error information for the failed create.
    /// <para>
    /// Learn about <see href="https://developer.squareup.com/docs/team/troubleshooting#bulk-create-team-members">Troubleshooting the Team API</see>.
    /// </para>
    /// </remarks>
    public Task<BulkCreateTeamMembersResponse> BulkCreateTeamMembers(BulkCreateTeamMembersRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/team-members/bulk-create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BulkCreateTeamMembersResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// BulkUpdateTeamMembers
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkUpdateTeamMembersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates multiple <c>TeamMember</c> objects. The updated <c>TeamMember</c> objects are returned on successful updates.
    /// This process is non-transactional and processes as much of the request as possible. If one of the updates in
    /// the request cannot be successfully processed, the request is not marked as failed, but the body of the response
    /// contains explicit error information for the failed update.
    /// Learn about <see href="https://developer.squareup.com/docs/team/troubleshooting#bulk-update-team-members">Troubleshooting the Team API</see>.
    /// </remarks>
    public Task<BulkUpdateTeamMembersResponse> BulkUpdateTeamMembers(BulkUpdateTeamMembersRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/team-members/bulk-update"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BulkUpdateTeamMembersResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// CreateJob
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateJobResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a job in a seller account. A job defines a title and tip eligibility. Note that
    /// compensation is defined in a <see href="entity:JobAssignment">job assignment</see> in a team member's wage setting.
    /// </remarks>
    public Task<CreateJobResponse> CreateJob(CreateJobRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/team-members/jobs"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateJobResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// CreateTeamMember
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateTeamMemberResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a single <c>TeamMember</c> object. The <c>TeamMember</c> object is returned on successful creates.
    /// You must provide the following values in your request to this endpoint:
    /// - <c>given_name</c>
    /// - <c>family_name</c>
    /// <para>
    /// Learn about <see href="https://developer.squareup.com/docs/team/troubleshooting#createteammember">Troubleshooting the Team API</see>.
    /// </para>
    /// </remarks>
    public Task<CreateTeamMemberResponse> CreateTeamMember(CreateTeamMemberRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/team-members"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateTeamMemberResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListJobs
    /// </summary>
    /// <param name="cursor">The pagination cursor returned by the previous call to this endpoint. Provide this cursor to retrieve the next page of results for your original request. For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListJobsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists jobs in a seller account. Results are sorted by title in ascending order.
    /// </remarks>
    public Task<ListJobsResponse> ListJobs(string? cursor,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/team-members/jobs"),
            [],
            [new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListJobsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveJob
    /// </summary>
    /// <param name="jobId">The ID of the job to retrieve.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveJobResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a specified job.
    /// </remarks>
    public Task<RetrieveJobResponse> RetrieveJob(string jobId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/team-members/jobs/{job_id}"),
            [new TemplateParam("job_id", jobId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveJobResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveTeamMember
    /// </summary>
    /// <param name="teamMemberId">The ID of the team member to retrieve.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveTeamMemberResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a <c>TeamMember</c> object for the given <c>TeamMember.id</c>.
    /// Learn about <see href="https://developer.squareup.com/docs/team/troubleshooting#retrieve-a-team-member">Troubleshooting the Team API</see>.
    /// </remarks>
    public Task<RetrieveTeamMemberResponse> RetrieveTeamMember(string teamMemberId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/team-members/{team_member_id}"),
            [new TemplateParam("team_member_id", teamMemberId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveTeamMemberResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveWageSetting
    /// </summary>
    /// <param name="teamMemberId">The ID of the team member for which to retrieve the wage setting.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveWageSettingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a <c>WageSetting</c> object for a team member specified
    /// by <c>TeamMember.id</c>. For more information, see
    /// <see href="https://developer.squareup.com/docs/team/troubleshooting#retrievewagesetting">Troubleshooting the Team API</see>.
    /// <para>
    /// Square recommends using <see href="api-endpoint:Team-RetrieveTeamMember">RetrieveTeamMember</see> or <see href="api-endpoint:Team-SearchTeamMembers">SearchTeamMembers</see>
    /// to get this information directly from the <c>TeamMember.wage_setting</c> field.
    /// </para>
    /// </remarks>
    public Task<RetrieveWageSettingResponse> RetrieveWageSetting(string teamMemberId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/team-members/{team_member_id}/wage-setting"),
            [new TemplateParam("team_member_id", teamMemberId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveWageSettingResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// SearchTeamMembers
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchTeamMembersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of <c>TeamMember</c> objects for a business.
    /// The list can be filtered by location IDs, <c>ACTIVE</c> or <c>INACTIVE</c> status, or whether
    /// the team member is the Square account owner.
    /// </remarks>
    public Task<SearchTeamMembersResponse> SearchTeamMembers(SearchTeamMembersRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/team-members/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchTeamMembersResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// UpdateJob
    /// </summary>
    /// <param name="jobId">The ID of the job to update.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateJobResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the title or tip eligibility of a job. Changes to the title propagate to all
    /// <c>JobAssignment</c>, <c>Shift</c>, and <c>TeamMemberWage</c> objects that reference the job ID. Changes to
    /// tip eligibility propagate to all <c>TeamMemberWage</c> objects that reference the job ID.
    /// </remarks>
    public Task<UpdateJobResponse> UpdateJob(string jobId,
        UpdateJobRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/team-members/jobs/{job_id}"),
            [new TemplateParam("job_id", jobId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateJobResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// UpdateTeamMember
    /// </summary>
    /// <param name="teamMemberId">The ID of the team member to update.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateTeamMemberResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a single <c>TeamMember</c> object. The <c>TeamMember</c> object is returned on successful updates.
    /// Learn about <see href="https://developer.squareup.com/docs/team/troubleshooting#update-a-team-member">Troubleshooting the Team API</see>.
    /// </remarks>
    public Task<UpdateTeamMemberResponse> UpdateTeamMember(string teamMemberId,
        UpdateTeamMemberRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/team-members/{team_member_id}"),
            [new TemplateParam("team_member_id", teamMemberId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateTeamMemberResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// UpdateWageSetting
    /// </summary>
    /// <param name="teamMemberId">The ID of the team member for which to update the <c>WageSetting</c> object.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateWageSettingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates or updates a <c>WageSetting</c> object. The object is created if a
    /// <c>WageSetting</c> with the specified <c>team_member_id</c> doesn't exist. Otherwise,
    /// it fully replaces the <c>WageSetting</c> object for the team member.
    /// The <c>WageSetting</c> is returned on a successful update. For more information, see
    /// <see href="https://developer.squareup.com/docs/team/troubleshooting#create-or-update-a-wage-setting">Troubleshooting the Team API</see>.
    /// <para>
    /// Square recommends using <see href="api-endpoint:Team-CreateTeamMember">CreateTeamMember</see> or <see href="api-endpoint:Team-UpdateTeamMember">UpdateTeamMember</see>
    /// to manage the <c>TeamMember.wage_setting</c> field directly.
    /// </para>
    /// </remarks>
    public Task<UpdateWageSettingResponse> UpdateWageSetting(string teamMemberId,
        UpdateWageSettingRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/team-members/{team_member_id}/wage-setting"),
            [new TemplateParam("team_member_id", teamMemberId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateWageSettingResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);
}

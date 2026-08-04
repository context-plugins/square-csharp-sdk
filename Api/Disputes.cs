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
using Square.Models.Enums;

namespace Square.Api;

public sealed class Disputes
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Disputes(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// AcceptDispute
    /// </summary>
    /// <param name="disputeId">The ID of the dispute you want to accept.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AcceptDisputeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Accepts the loss on a dispute. Square returns the disputed amount to the cardholder and
    /// updates the dispute state to ACCEPTED.
    /// <para>
    /// Square debits the disputed amount from the seller’s Square account. If the Square account
    /// does not have sufficient funds, Square debits the associated bank account.
    /// </para>
    /// </remarks>
    public Task<AcceptDisputeResponse> AcceptDispute(string disputeId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/disputes/{dispute_id}/accept"),
            [new TemplateParam("dispute_id", disputeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<AcceptDisputeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// CreateDisputeEvidenceFile
    /// </summary>
    /// <param name="disputeId">The ID of the dispute for which you want to upload evidence.</param>
    /// <param name="request"></param>
    /// <param name="imageFile"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateDisputeEvidenceFileResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uploads a file to use as evidence in a dispute challenge. The endpoint accepts HTTP
    /// multipart/form-data file uploads in HEIC, HEIF, JPEG, PDF, PNG, and TIFF formats.
    /// </remarks>
    public Task<CreateDisputeEvidenceFileResponse> CreateDisputeEvidenceFile(string disputeId,
        CreateDisputeEvidenceFileRequest? request,
        BinaryContent? imageFile,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/disputes/{dispute_id}/evidence-files"),
            [new TemplateParam("dispute_id", disputeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create([new MultipartParam("request", request, "application/json; charset=utf-8"),
                    new MultipartParam("image_file", imageFile)]),
            JsonResponse.Create<CreateDisputeEvidenceFileResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// CreateDisputeEvidenceText
    /// </summary>
    /// <param name="disputeId">The ID of the dispute for which you want to upload evidence.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateDisputeEvidenceTextResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uploads text to use as evidence for a dispute challenge.
    /// </remarks>
    public Task<CreateDisputeEvidenceTextResponse> CreateDisputeEvidenceText(string disputeId,
        CreateDisputeEvidenceTextRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/disputes/{dispute_id}/evidence-text"),
            [new TemplateParam("dispute_id", disputeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateDisputeEvidenceTextResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// DeleteDisputeEvidence
    /// </summary>
    /// <param name="disputeId">The ID of the dispute from which you want to remove evidence.</param>
    /// <param name="evidenceId">The ID of the evidence you want to remove.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteDisputeEvidenceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes specified evidence from a dispute.
    /// Square does not send the bank any evidence that is removed.
    /// </remarks>
    public Task<DeleteDisputeEvidenceResponse> DeleteDisputeEvidence(string disputeId,
        string evidenceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/disputes/{dispute_id}/evidence/{evidence_id}"),
            [new TemplateParam("dispute_id", disputeId), new TemplateParam("evidence_id", evidenceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteDisputeEvidenceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListDisputeEvidence
    /// </summary>
    /// <param name="disputeId">The ID of the dispute.</param>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this cursor to retrieve the next set of results for the original query. For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListDisputeEvidenceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of evidence associated with a dispute.
    /// </remarks>
    public Task<ListDisputeEvidenceResponse> ListDisputeEvidence(string disputeId,
        string? cursor,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/disputes/{dispute_id}/evidence"),
            [new TemplateParam("dispute_id", disputeId)],
            [new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListDisputeEvidenceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListDisputes
    /// </summary>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this cursor to retrieve the next set of results for the original query. For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.</param>
    /// <param name="states">The dispute states used to filter the result. If not specified, the endpoint returns all disputes.</param>
    /// <param name="locationId">The ID of the location for which to return a list of disputes. If not specified, the endpoint returns disputes associated with all locations.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListDisputesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of disputes associated with a particular account.
    /// </remarks>
    public Task<ListDisputesResponse> ListDisputes(string? cursor,
        DisputeState? states,
        string? locationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/disputes"),
            [],
            [new Param("cursor", cursor), new Param("states", states), new Param("location_id", locationId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListDisputesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveDispute
    /// </summary>
    /// <param name="disputeId">The ID of the dispute you want more details about.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveDisputeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns details about a specific dispute.
    /// </remarks>
    public Task<RetrieveDisputeResponse> RetrieveDispute(string disputeId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/disputes/{dispute_id}"),
            [new TemplateParam("dispute_id", disputeId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveDisputeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveDisputeEvidence
    /// </summary>
    /// <param name="disputeId">The ID of the dispute from which you want to retrieve evidence metadata.</param>
    /// <param name="evidenceId">The ID of the evidence to retrieve.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveDisputeEvidenceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the metadata for the evidence specified in the request URL path.
    /// <para>
    /// You must maintain a copy of any evidence uploaded if you want to reference it later. Evidence cannot be downloaded after you upload it.
    /// </para>
    /// </remarks>
    public Task<RetrieveDisputeEvidenceResponse> RetrieveDisputeEvidence(string disputeId,
        string evidenceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/disputes/{dispute_id}/evidence/{evidence_id}"),
            [new TemplateParam("dispute_id", disputeId), new TemplateParam("evidence_id", evidenceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveDisputeEvidenceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// SubmitEvidence
    /// </summary>
    /// <param name="disputeId">The ID of the dispute for which you want to submit evidence.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SubmitEvidenceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Submits evidence to the cardholder's bank.
    /// <para>
    /// The evidence submitted by this endpoint includes evidence uploaded
    /// using the <see href="api-endpoint:Disputes-CreateDisputeEvidenceFile">CreateDisputeEvidenceFile</see> and
    /// <see href="api-endpoint:Disputes-CreateDisputeEvidenceText">CreateDisputeEvidenceText</see> endpoints and
    /// evidence automatically provided by Square, when available. Evidence cannot be removed from
    /// a dispute after submission.
    /// </para>
    /// </remarks>
    public Task<SubmitEvidenceResponse> SubmitEvidence(string disputeId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/disputes/{dispute_id}/submit-evidence"),
            [new TemplateParam("dispute_id", disputeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SubmitEvidenceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);
}

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
using Square.Requests.Disputes;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AcceptDisputeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Accepts the loss on a dispute. Square returns the disputed amount to the cardholder and
    /// updates the dispute state to ACCEPTED.
    /// <para>
    /// Square debits the disputed amount from the seller’s Square account. If the Square account
    /// does not have sufficient funds, Square debits the associated bank account.
    /// </para>
    /// </remarks>
    public Task<AcceptDisputeResponse> AcceptDispute(AcceptDisputeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/disputes/{dispute_id}/accept"),
            [new TemplateParam("dispute_id", request.DisputeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<AcceptDisputeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CreateDisputeEvidenceFile
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateDisputeEvidenceFileResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uploads a file to use as evidence in a dispute challenge. The endpoint accepts HTTP
    /// multipart/form-data file uploads in HEIC, HEIF, JPEG, PDF, PNG, and TIFF formats.
    /// </remarks>
    public Task<CreateDisputeEvidenceFileResponse> CreateDisputeEvidenceFile(CreateDisputeEvidenceFileOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/disputes/{dispute_id}/evidence-files"),
            [new TemplateParam("dispute_id", request.DisputeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create(
                new MultipartParam("request", request.Request, "application/json; charset=utf-8"),
                new MultipartParam("image_file", request.ImageFile)),
            JsonResponse.Create<CreateDisputeEvidenceFileResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CreateDisputeEvidenceText
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateDisputeEvidenceTextResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uploads text to use as evidence for a dispute challenge.
    /// </remarks>
    public Task<CreateDisputeEvidenceTextResponse> CreateDisputeEvidenceText(CreateDisputeEvidenceTextOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/disputes/{dispute_id}/evidence-text"),
            [new TemplateParam("dispute_id", request.DisputeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateDisputeEvidenceTextResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeleteDisputeEvidence
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteDisputeEvidenceResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes specified evidence from a dispute.
    /// Square does not send the bank any evidence that is removed.
    /// </remarks>
    public Task<DeleteDisputeEvidenceResponse> DeleteDisputeEvidence(DeleteDisputeEvidenceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/disputes/{dispute_id}/evidence/{evidence_id}"),
            [new TemplateParam("dispute_id", request.DisputeId), new TemplateParam("evidence_id", request.EvidenceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteDisputeEvidenceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListDisputeEvidence
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListDisputeEvidenceResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of evidence associated with a dispute.
    /// </remarks>
    public Task<ListDisputeEvidenceResponse> ListDisputeEvidence(ListDisputeEvidenceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/disputes/{dispute_id}/evidence"),
            [new TemplateParam("dispute_id", request.DisputeId)],
            [new Param("cursor", request.Cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListDisputeEvidenceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListDisputes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListDisputesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of disputes associated with a particular account.
    /// </remarks>
    public Task<ListDisputesResponse> ListDisputes(ListDisputesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/disputes"),
            [],
            [
                new Param("cursor", request.Cursor),
                new Param("states", request.States),
                new Param("location_id", request.LocationId),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListDisputesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveDispute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveDisputeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns details about a specific dispute.
    /// </remarks>
    public Task<RetrieveDisputeResponse> RetrieveDispute(RetrieveDisputeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/disputes/{dispute_id}"),
            [new TemplateParam("dispute_id", request.DisputeId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveDisputeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveDisputeEvidence
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveDisputeEvidenceResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the metadata for the evidence specified in the request URL path.
    /// <para>
    /// You must maintain a copy of any evidence uploaded if you want to reference it later. Evidence cannot be downloaded after you upload it.
    /// </para>
    /// </remarks>
    public Task<RetrieveDisputeEvidenceResponse> RetrieveDisputeEvidence(RetrieveDisputeEvidenceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/disputes/{dispute_id}/evidence/{evidence_id}"),
            [new TemplateParam("dispute_id", request.DisputeId), new TemplateParam("evidence_id", request.EvidenceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveDisputeEvidenceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// SubmitEvidence
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SubmitEvidenceResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<SubmitEvidenceResponse> SubmitEvidence(SubmitEvidenceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/disputes/{dispute_id}/submit-evidence"),
            [new TemplateParam("dispute_id", request.DisputeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SubmitEvidenceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}

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
using Square.Requests.CustomerGroups;

namespace Square.Api;

public sealed class CustomerGroups
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal CustomerGroups(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CreateCustomerGroup
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateCustomerGroupResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new customer group for a business.
    /// <para>
    /// The request must include the <c>name</c> value of the group.
    /// </para>
    /// </remarks>
    public Task<CreateCustomerGroupResponse> CreateCustomerGroup(CreateCustomerGroupOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/groups"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateCustomerGroupResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeleteCustomerGroup
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteCustomerGroupResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a customer group as identified by the <c>group_id</c> value.
    /// </remarks>
    public Task<DeleteCustomerGroupResponse> DeleteCustomerGroup(DeleteCustomerGroupRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/groups/{group_id}"),
            [new TemplateParam("group_id", request.GroupId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteCustomerGroupResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListCustomerGroups
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCustomerGroupsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the list of customer groups of a business.
    /// </remarks>
    public Task<ListCustomerGroupsResponse> ListCustomerGroups(ListCustomerGroupsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/groups"),
            [],
            [new Param("cursor", request.Cursor), new Param("limit", request.Limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCustomerGroupsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveCustomerGroup
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveCustomerGroupResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a specific customer group as identified by the <c>group_id</c> value.
    /// </remarks>
    public Task<RetrieveCustomerGroupResponse> RetrieveCustomerGroup(RetrieveCustomerGroupRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/groups/{group_id}"),
            [new TemplateParam("group_id", request.GroupId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveCustomerGroupResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpdateCustomerGroup
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateCustomerGroupResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a customer group as identified by the <c>group_id</c> value.
    /// </remarks>
    public Task<UpdateCustomerGroupResponse> UpdateCustomerGroup(UpdateCustomerGroupOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/groups/{group_id}"),
            [new TemplateParam("group_id", request.GroupId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateCustomerGroupResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}

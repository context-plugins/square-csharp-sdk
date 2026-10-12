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
using Square.Requests.Snippets;

namespace Square.Api;

public sealed class Snippets
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Snippets(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// DeleteSnippet
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteSnippetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes your snippet from a Square Online site.
    /// <para>
    /// You can call <see href="api-endpoint:Sites-ListSites">ListSites</see> to get the IDs of the sites that belong to a seller.
    /// </para>
    /// <para>
    ///
    /// __Note:__ Square Online APIs are publicly available as part of an early access program. For more information, see <see href="https://developer.squareup.com/docs/online-api#early-access-program-for-square-online-apis">Early access program for Square Online APIs</see>.
    /// </para>
    /// </remarks>
    public Task<DeleteSnippetResponse> DeleteSnippet(DeleteSnippetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/sites/{site_id}/snippet"),
            [new TemplateParam("site_id", request.SiteId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteSnippetResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveSnippet
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveSnippetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves your snippet from a Square Online site. A site can contain snippets from multiple snippet applications, but you can retrieve only the snippet that was added by your application.
    /// <para>
    /// You can call <see href="api-endpoint:Sites-ListSites">ListSites</see> to get the IDs of the sites that belong to a seller.
    /// </para>
    /// <para>
    ///
    /// __Note:__ Square Online APIs are publicly available as part of an early access program. For more information, see <see href="https://developer.squareup.com/docs/online-api#early-access-program-for-square-online-apis">Early access program for Square Online APIs</see>.
    /// </para>
    /// </remarks>
    public Task<RetrieveSnippetResponse> RetrieveSnippet(RetrieveSnippetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/sites/{site_id}/snippet"),
            [new TemplateParam("site_id", request.SiteId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveSnippetResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpsertSnippet
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpsertSnippetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds a snippet to a Square Online site or updates the existing snippet on the site.
    /// The snippet code is appended to the end of the <c>head</c> element on every page of the site, except checkout pages. A snippet application can add one snippet to a given site.
    /// <para>
    /// You can call <see href="api-endpoint:Sites-ListSites">ListSites</see> to get the IDs of the sites that belong to a seller.
    /// </para>
    /// <para>
    ///
    /// __Note:__ Square Online APIs are publicly available as part of an early access program. For more information, see <see href="https://developer.squareup.com/docs/online-api#early-access-program-for-square-online-apis">Early access program for Square Online APIs</see>.
    /// </para>
    /// </remarks>
    public Task<UpsertSnippetResponse> UpsertSnippet(UpsertSnippetOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/sites/{site_id}/snippet"),
            [new TemplateParam("site_id", request.SiteId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpsertSnippetResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}

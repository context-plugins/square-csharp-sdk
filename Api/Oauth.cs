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

public sealed class Oauth
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Oauth(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// ObtainToken
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ObtainTokenResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns an OAuth access token and refresh token using the <c>authorization_code</c>
    /// or <c>refresh_token</c> grant type.
    /// <para>
    /// When <c>grant_type</c> is <c>authorization_code</c>:
    /// - With the <see href="https://developer.squareup.com/docs/oauth-api/overview#code-flow">code flow</see>,
    /// provide <c>code</c>, <c>client_id</c>, and <c>client_secret</c>.
    /// - With the <see href="https://developer.squareup.com/docs/oauth-api/overview#pkce-flow">PKCE flow</see>,
    /// provide <c>code</c>, <c>client_id</c>, and <c>code_verifier</c>.
    /// </para>
    /// <para>
    /// When <c>grant_type</c> is <c>refresh_token</c>:
    /// - With the code flow, provide <c>refresh_token</c>, <c>client_id</c>, and <c>client_secret</c>.
    /// The response returns the same refresh token provided in the request.
    /// - With the PKCE flow, provide <c>refresh_token</c> and <c>client_id</c>. The response returns
    /// a new refresh token.
    /// </para>
    /// <para>
    /// You can use the <c>scopes</c> parameter to limit the set of permissions authorized by the
    /// access token. You can use the <c>short_lived</c> parameter to create an access token that
    /// expires in 24 hours.
    /// </para>
    /// <para>
    /// __Important:__ OAuth tokens should be encrypted and stored on a secure server.
    /// Application clients should never interact directly with OAuth tokens.
    /// </para>
    /// </remarks>
    public Task<ObtainTokenResponse> ObtainToken(ObtainTokenRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/oauth2/token"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ObtainTokenResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveTokenStatus
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveTokenStatusResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns information about an <see href="https://developer.squareup.com/docs/build-basics/access-tokens#get-an-oauth-access-token">OAuth access token</see> or an application’s <see href="https://developer.squareup.com/docs/build-basics/access-tokens#get-a-personal-access-token">personal access token</see>.
    /// <para>
    /// Add the access token to the Authorization header of the request.
    /// </para>
    /// <para>
    /// __Important:__ The <c>Authorization</c> header you provide to this endpoint must have the following format:
    /// </para>
    /// <code>
    /// Authorization: Bearer ACCESS_TOKEN
    /// </code>
    /// <para>
    /// where <c>ACCESS_TOKEN</c> is a
    /// <see href="https://developer.squareup.com/docs/build-basics/access-tokens">valid production authorization credential</see>.
    /// </para>
    /// <para>
    /// If the access token is expired or not a valid access token, the endpoint returns an <c>UNAUTHORIZED</c> error.
    /// </para>
    /// </remarks>
    public Task<RetrieveTokenStatusResponse> RetrieveTokenStatus(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/oauth2/token/status"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveTokenStatusResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RevokeToken
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RevokeTokenResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Revokes an access token generated with the OAuth flow.
    /// <para>
    /// If an account has more than one OAuth access token for your application, this
    /// endpoint revokes all of them, regardless of which token you specify.
    /// </para>
    /// <para>
    /// __Important:__ The <c>Authorization</c> header for this endpoint must have the
    /// following format:
    /// </para>
    /// <code>
    /// Authorization: Client APPLICATION_SECRET
    /// </code>
    /// <para>
    /// Replace <c>APPLICATION_SECRET</c> with the application secret on the <b>OAuth</b>
    /// page for your application in the Developer Dashboard.
    /// </para>
    /// </remarks>
    public Task<RevokeTokenResponse> RevokeToken(RevokeTokenRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/oauth2/revoke"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RevokeTokenResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}

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
using Square.Requests.ApplePay;

namespace Square.Api;

public sealed class ApplePay
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ApplePay(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// RegisterDomain
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RegisterDomainResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Activates a domain for use with Apple Pay on the Web and Square. A validation
    /// is performed on this domain by Apple to ensure that it is properly set up as
    /// an Apple Pay enabled domain.
    /// <para>
    /// This endpoint provides an easy way for platform developers to bulk activate
    /// Apple Pay on the Web with Square for merchants using their platform.
    /// </para>
    /// <para>
    /// Note: You will need to host a valid domain verification file on your domain to support Apple Pay.  The
    /// current version of this file is always available at https://app.squareup.com/digital-wallets/apple-pay/apple-developer-merchantid-domain-association,
    /// and should be hosted at <c>.well_known/apple-developer-merchantid-domain-association</c> on your
    /// domain.  This file is subject to change; we strongly recommend checking for updates regularly and avoiding
    /// long-lived caches that might not keep in sync with the correct file version.
    /// </para>
    /// <para>
    /// To learn more about the Web Payments SDK and how to add Apple Pay, see <see href="https://developer.squareup.com/docs/web-payments/apple-pay">Take an Apple Pay Payment</see>.
    /// </para>
    /// </remarks>
    public Task<RegisterDomainResponse> RegisterDomain(RegisterDomainOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/apple-pay/domains"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<RegisterDomainResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}

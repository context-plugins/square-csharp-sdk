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
using Square.Requests.Merchants;

namespace Square.Api;

public sealed class Merchants
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Merchants(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// ListMerchants
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListMerchantsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides details about the merchant associated with a given access token.
    /// <para>
    /// The access token used to connect your application to a Square seller is associated
    /// with a single merchant. That means that <c>ListMerchants</c> returns a list
    /// with a single <c>Merchant</c> object. You can specify your personal access token
    /// to get your own merchant information or specify an OAuth token to get the
    /// information for the merchant that granted your application access.
    /// </para>
    /// <para>
    /// If you know the merchant ID, you can also use the <see href="api-endpoint:Merchants-RetrieveMerchant">RetrieveMerchant</see>
    /// endpoint to retrieve the merchant information.
    /// </para>
    /// </remarks>
    public Task<ListMerchantsResponse> ListMerchants(ListMerchantsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/merchants"),
            [],
            [new Param("cursor", request.Cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListMerchantsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveMerchant
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveMerchantResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the <c>Merchant</c> object for the given <c>merchant_id</c>.
    /// </remarks>
    public Task<RetrieveMerchantResponse> RetrieveMerchant(RetrieveMerchantRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/merchants/{merchant_id}"),
            [new TemplateParam("merchant_id", request.MerchantId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveMerchantResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}

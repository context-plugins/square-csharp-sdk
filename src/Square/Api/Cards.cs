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
using Square.Requests.Cards;

namespace Square.Api;

public sealed class Cards
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Cards(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CreateCard
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateCardResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds a card on file to an existing merchant.
    /// </remarks>
    public Task<CreateCardResponse> CreateCard(CreateCardOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/cards"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateCardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DisableCard
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DisableCardResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Disables the card, preventing any further updates or charges.
    /// Disabling an already disabled card is allowed but has no effect.
    /// </remarks>
    public Task<DisableCardResponse> DisableCard(DisableCardRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/cards/{card_id}/disable"),
            [new TemplateParam("card_id", request.CardId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<DisableCardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListCards
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCardsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a list of cards owned by the account making the request.
    /// A max of 25 cards will be returned.
    /// </remarks>
    public Task<ListCardsResponse> ListCards(ListCardsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/cards"),
            [],
            [
                new Param("cursor", request.Cursor),
                new Param("customer_id", request.CustomerId),
                new Param("include_disabled", request.IncludeDisabled),
                new Param("reference_id", request.ReferenceId),
                new Param("sort_order", request.SortOrder),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCardsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveCard
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveCardResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves details for a specific Card.
    /// </remarks>
    public Task<RetrieveCardResponse> RetrieveCard(RetrieveCardRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/cards/{card_id}"),
            [new TemplateParam("card_id", request.CardId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveCardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}

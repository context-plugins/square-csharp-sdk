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

public sealed class GiftCards
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal GiftCards(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CreateGiftCard
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateGiftCardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a digital gift card or registers a physical (plastic) gift card. The resulting gift card
    /// has a <c>PENDING</c> state. To activate a gift card so that it can be redeemed for purchases, call
    /// <see href="api-endpoint:GiftCardActivities-CreateGiftCardActivity">CreateGiftCardActivity</see> and create an <c>ACTIVATE</c>
    /// activity with the initial balance. Alternatively, you can use <see href="api-endpoint:Refunds-RefundPayment">RefundPayment</see>
    /// to refund a payment to the new gift card.
    /// </remarks>
    public Task<CreateGiftCardResponse> CreateGiftCard(CreateGiftCardRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/gift-cards"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateGiftCardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// LinkCustomerToGiftCard
    /// </summary>
    /// <param name="giftCardId">The ID of the gift card to be linked.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LinkCustomerToGiftCardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Links a customer to a gift card, which is also referred to as adding a card on file.
    /// </remarks>
    public Task<LinkCustomerToGiftCardResponse> LinkCustomerToGiftCard(string giftCardId,
        LinkCustomerToGiftCardRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/gift-cards/{gift_card_id}/link-customer"),
            [new TemplateParam("gift_card_id", giftCardId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<LinkCustomerToGiftCardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListGiftCards
    /// </summary>
    /// <param name="type">If a <see href="entity:GiftCardType">type</see> is provided, the endpoint returns gift cards of the specified type. Otherwise, the endpoint returns gift cards of all types.</param>
    /// <param name="state">If a <see href="entity:GiftCardStatus">state</see> is provided, the endpoint returns the gift cards in the specified state. Otherwise, the endpoint returns the gift cards of all states.</param>
    /// <param name="limit">If a limit is provided, the endpoint returns only the specified number of results per page. The maximum value is 200. The default value is 30. For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.</param>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this cursor to retrieve the next set of results for the original query. If a cursor is not provided, the endpoint returns the first page of the results.  For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.</param>
    /// <param name="customerId">If a customer ID is provided, the endpoint returns only the gift cards linked to the specified customer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListGiftCardsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists all gift cards. You can specify optional filters to retrieve
    /// a subset of the gift cards. Results are sorted by <c>created_at</c> in ascending order.
    /// </remarks>
    public Task<ListGiftCardsResponse> ListGiftCards(string? type,
        string? state,
        int? limit,
        string? cursor,
        string? customerId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/gift-cards"),
            [],
            [new Param("type", type),
                new Param("state", state),
                new Param("limit", limit),
                new Param("cursor", cursor),
                new Param("customer_id", customerId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListGiftCardsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveGiftCard
    /// </summary>
    /// <param name="id">The ID of the gift card to retrieve.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveGiftCardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a gift card using the gift card ID.
    /// </remarks>
    public Task<RetrieveGiftCardResponse> RetrieveGiftCard(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/gift-cards/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveGiftCardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveGiftCardFromGAN
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveGiftCardFromGanResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a gift card using the gift card account number (GAN).
    /// </remarks>
    public Task<RetrieveGiftCardFromGanResponse> RetrieveGiftCardFromGan(RetrieveGiftCardFromGanRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/gift-cards/from-gan"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RetrieveGiftCardFromGanResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveGiftCardFromNonce
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveGiftCardFromNonceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a gift card using a secure payment token that represents the gift card.
    /// </remarks>
    public Task<RetrieveGiftCardFromNonceResponse> RetrieveGiftCardFromNonce(RetrieveGiftCardFromNonceRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/gift-cards/from-nonce"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RetrieveGiftCardFromNonceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// UnlinkCustomerFromGiftCard
    /// </summary>
    /// <param name="giftCardId">The ID of the gift card to be unlinked.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UnlinkCustomerFromGiftCardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Unlinks a customer from a gift card, which is also referred to as removing a card on file.
    /// </remarks>
    public Task<UnlinkCustomerFromGiftCardResponse> UnlinkCustomerFromGiftCard(string giftCardId,
        UnlinkCustomerFromGiftCardRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/gift-cards/{gift_card_id}/unlink-customer"),
            [new TemplateParam("gift_card_id", giftCardId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UnlinkCustomerFromGiftCardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);
}

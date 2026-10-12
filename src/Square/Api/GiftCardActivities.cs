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
using Square.Requests.GiftCardActivities;

namespace Square.Api;

public sealed class GiftCardActivities
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal GiftCardActivities(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CreateGiftCardActivity
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateGiftCardActivityResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a gift card activity to manage the balance or state of a <see href="entity:GiftCard">gift card</see>.
    /// For example, create an <c>ACTIVATE</c> activity to activate a gift card with an initial balance before first use.
    /// </remarks>
    public Task<CreateGiftCardActivityResponse> CreateGiftCardActivity(CreateGiftCardActivityOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/gift-cards/activities"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateGiftCardActivityResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListGiftCardActivities
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListGiftCardActivitiesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists gift card activities. By default, you get gift card activities for all
    /// gift cards in the seller's account. You can optionally specify query parameters to
    /// filter the list. For example, you can get a list of gift card activities for a gift card,
    /// for all gift cards in a specific region, or for activities within a time window.
    /// </remarks>
    public Task<ListGiftCardActivitiesResponse> ListGiftCardActivities(ListGiftCardActivitiesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/gift-cards/activities"),
            [],
            [
                new Param("gift_card_id", request.GiftCardId),
                new Param("type", request.Type),
                new Param("location_id", request.LocationId),
                new Param("begin_time", request.BeginTime),
                new Param("end_time", request.EndTime),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
                new Param("sort_order", request.SortOrder),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListGiftCardActivitiesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}

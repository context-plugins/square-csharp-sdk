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
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateGiftCardActivityResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a gift card activity to manage the balance or state of a <see href="entity:GiftCard">gift card</see>.
    /// For example, create an <c>ACTIVATE</c> activity to activate a gift card with an initial balance before first use.
    /// </remarks>
    public Task<CreateGiftCardActivityResponse> CreateGiftCardActivity(CreateGiftCardActivityRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/gift-cards/activities"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateGiftCardActivityResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListGiftCardActivities
    /// </summary>
    /// <param name="giftCardId">If a gift card ID is provided, the endpoint returns activities related  to the specified gift card. Otherwise, the endpoint returns all gift card activities for  the seller.</param>
    /// <param name="type">If a <see href="entity:GiftCardActivityType">type</see> is provided, the endpoint returns gift card activities of the specified type.  Otherwise, the endpoint returns all types of gift card activities.</param>
    /// <param name="locationId">If a location ID is provided, the endpoint returns gift card activities for the specified location.  Otherwise, the endpoint returns gift card activities for all locations.</param>
    /// <param name="beginTime">The timestamp for the beginning of the reporting period, in RFC 3339 format. This start time is inclusive. The default value is the current time minus one year.</param>
    /// <param name="endTime">The timestamp for the end of the reporting period, in RFC 3339 format. This end time is inclusive. The default value is the current time.</param>
    /// <param name="limit">If a limit is provided, the endpoint returns the specified number  of results (or fewer) per page. The maximum value is 100. The default value is 50. For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.</param>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this cursor to retrieve the next set of results for the original query. If a cursor is not provided, the endpoint returns the first page of the results. For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.</param>
    /// <param name="sortOrder">The order in which the endpoint returns the activities, based on <c>created_at</c>. - <c>ASC</c> - Oldest to newest. - <c>DESC</c> - Newest to oldest (default).</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListGiftCardActivitiesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists gift card activities. By default, you get gift card activities for all
    /// gift cards in the seller's account. You can optionally specify query parameters to
    /// filter the list. For example, you can get a list of gift card activities for a gift card,
    /// for all gift cards in a specific region, or for activities within a time window.
    /// </remarks>
    public Task<ListGiftCardActivitiesResponse> ListGiftCardActivities(string? giftCardId,
        string? type,
        string? locationId,
        string? beginTime,
        string? endTime,
        int? limit,
        string? cursor,
        string? sortOrder,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/gift-cards/activities"),
            [],
            [new Param("gift_card_id", giftCardId),
                new Param("type", type),
                new Param("location_id", locationId),
                new Param("begin_time", beginTime),
                new Param("end_time", endTime),
                new Param("limit", limit),
                new Param("cursor", cursor),
                new Param("sort_order", sortOrder)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListGiftCardActivitiesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);
}

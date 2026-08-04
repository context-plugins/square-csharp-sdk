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
using Square.Models.Enums;

namespace Square.Api;

public sealed class Payouts
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Payouts(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// GetPayout
    /// </summary>
    /// <param name="payoutId">The ID of the payout to retrieve the information for.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetPayoutResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves details of a specific payout identified by a payout ID.
    /// To call this endpoint, set <c>PAYOUTS_READ</c> for the OAuth scope.
    /// </remarks>
    public Task<GetPayoutResponse> GetPayout(string payoutId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/payouts/{payout_id}"),
            [new TemplateParam("payout_id", payoutId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetPayoutResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListPayoutEntries
    /// </summary>
    /// <param name="payoutId">The ID of the payout to retrieve the information for.</param>
    /// <param name="sortOrder">The order in which payout entries are listed.</param>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this cursor to retrieve the next set of results for the original query. For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>. If request parameters change between requests, subsequent results may contain duplicates or missing records.</param>
    /// <param name="limit">The maximum number of results to be returned in a single page. It is possible to receive fewer results than the specified limit on a given page. The default value of 100 is also the maximum allowed value. If the provided value is greater than 100, it is ignored and the default value is used instead. Default: <c>100</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListPayoutEntriesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a list of all payout entries for a specific payout.
    /// To call this endpoint, set <c>PAYOUTS_READ</c> for the OAuth scope.
    /// </remarks>
    public Task<ListPayoutEntriesResponse> ListPayoutEntries(string payoutId,
        SortOrder? sortOrder,
        string? cursor,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/payouts/{payout_id}/payout-entries"),
            [new TemplateParam("payout_id", payoutId)],
            [new Param("sort_order", sortOrder), new Param("cursor", cursor), new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListPayoutEntriesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListPayouts
    /// </summary>
    /// <param name="locationId">The ID of the location for which to list the payouts. By default, payouts are returned for the default (main) location associated with the seller.</param>
    /// <param name="status">If provided, only payouts with the given status are returned.</param>
    /// <param name="beginTime">The timestamp for the beginning of the payout creation time, in RFC 3339 format. Inclusive. Default: The current time minus one year.</param>
    /// <param name="endTime">The timestamp for the end of the payout creation time, in RFC 3339 format. Default: The current time.</param>
    /// <param name="sortOrder">The order in which payouts are listed.</param>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this cursor to retrieve the next set of results for the original query. For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>. If request parameters change between requests, subsequent results may contain duplicates or missing records.</param>
    /// <param name="limit">The maximum number of results to be returned in a single page. It is possible to receive fewer results than the specified limit on a given page. The default value of 100 is also the maximum allowed value. If the provided value is greater than 100, it is ignored and the default value is used instead. Default: <c>100</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListPayoutsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a list of all payouts for the default location.
    /// You can filter payouts by location ID, status, time range, and order them in ascending or descending order.
    /// To call this endpoint, set <c>PAYOUTS_READ</c> for the OAuth scope.
    /// </remarks>
    public Task<ListPayoutsResponse> ListPayouts(string? locationId,
        PayoutStatus? status,
        string? beginTime,
        string? endTime,
        SortOrder? sortOrder,
        string? cursor,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/payouts"),
            [],
            [new Param("location_id", locationId),
                new Param("status", status),
                new Param("begin_time", beginTime),
                new Param("end_time", endTime),
                new Param("sort_order", sortOrder),
                new Param("cursor", cursor),
                new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListPayoutsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);
}

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
using Square.Requests.CashDrawers;

namespace Square.Api;

public sealed class CashDrawers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal CashDrawers(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// ListCashDrawerShiftEvents
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCashDrawerShiftEventsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides a paginated list of events for a single cash drawer shift.
    /// </remarks>
    public Task<ListCashDrawerShiftEventsResponse> ListCashDrawerShiftEvents(ListCashDrawerShiftEventsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/cash-drawers/shifts/{shift_id}/events"),
            [new TemplateParam("shift_id", request.ShiftId)],
            [
                new Param("location_id", request.LocationId),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCashDrawerShiftEventsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListCashDrawerShifts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCashDrawerShiftsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides the details for all of the cash drawer shifts for a location
    /// in a date range.
    /// </remarks>
    public Task<ListCashDrawerShiftsResponse> ListCashDrawerShifts(ListCashDrawerShiftsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/cash-drawers/shifts"),
            [],
            [
                new Param("location_id", request.LocationId),
                new Param("sort_order", request.SortOrder),
                new Param("begin_time", request.BeginTime),
                new Param("end_time", request.EndTime),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCashDrawerShiftsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveCashDrawerShift
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveCashDrawerShiftResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides the summary details for a single cash drawer shift. See
    /// <see href="api-endpoint:CashDrawers-ListCashDrawerShiftEvents">ListCashDrawerShiftEvents</see> for a list of cash drawer shift events.
    /// </remarks>
    public Task<RetrieveCashDrawerShiftResponse> RetrieveCashDrawerShift(RetrieveCashDrawerShiftRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/cash-drawers/shifts/{shift_id}"),
            [new TemplateParam("shift_id", request.ShiftId)],
            [new Param("location_id", request.LocationId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveCashDrawerShiftResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}

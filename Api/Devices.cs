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
using Square.Models.Enums;

namespace Square.Api;

public sealed class Devices
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Devices(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CreateDeviceCode
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateDeviceCodeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a DeviceCode that can be used to login to a Square Terminal device to enter the connected
    /// terminal mode.
    /// </remarks>
    public Task<CreateDeviceCodeResponse> CreateDeviceCode(CreateDeviceCodeRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/devices/codes"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateDeviceCodeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// GetDevice
    /// </summary>
    /// <param name="deviceId">The unique ID for the desired <c>Device</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetDeviceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves Device with the associated <c>device_id</c>.
    /// </remarks>
    public Task<GetDeviceResponse> GetDevice(string deviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/devices/{device_id}"),
            [new TemplateParam("device_id", deviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetDeviceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// GetDeviceCode
    /// </summary>
    /// <param name="id">The unique identifier for the device code.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetDeviceCodeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves DeviceCode with the associated ID.
    /// </remarks>
    public Task<GetDeviceCodeResponse> GetDeviceCode(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/devices/codes/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetDeviceCodeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListDeviceCodes
    /// </summary>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query.  See <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Paginating results</see> for more information.</param>
    /// <param name="locationId">If specified, only returns DeviceCodes of the specified location. Returns DeviceCodes of all locations if empty.</param>
    /// <param name="productType">If specified, only returns DeviceCodes targeting the specified product type. Returns DeviceCodes of all product types if empty.</param>
    /// <param name="status">If specified, returns DeviceCodes with the specified statuses. Returns DeviceCodes of status <c>PAIRED</c> and <c>UNPAIRED</c> if empty.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListDeviceCodesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists all DeviceCodes associated with the merchant.
    /// </remarks>
    public Task<ListDeviceCodesResponse> ListDeviceCodes(string? cursor,
        string? locationId,
        ProductType? productType,
        DeviceCodeStatus? status,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/devices/codes"),
            [],
            [new Param("cursor", cursor),
                new Param("location_id", locationId),
                new Param("product_type", productType),
                new Param("status", status)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListDeviceCodesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListDevices
    /// </summary>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this cursor to retrieve the next set of results for the original query. See <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see> for more information.</param>
    /// <param name="sortOrder">The order in which results are listed. - <c>ASC</c> - Oldest to newest. - <c>DESC</c> - Newest to oldest (default).</param>
    /// <param name="limit">The number of results to return in a single page.</param>
    /// <param name="locationId">If present, only returns devices at the target location.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListDevicesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List devices associated with the merchant. Currently, only Terminal API
    /// devices are supported.
    /// </remarks>
    public Task<ListDevicesResponse> ListDevices(string? cursor,
        SortOrder? sortOrder,
        int? limit,
        string? locationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/devices"),
            [],
            [new Param("cursor", cursor),
                new Param("sort_order", sortOrder),
                new Param("limit", limit),
                new Param("location_id", locationId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListDevicesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);
}

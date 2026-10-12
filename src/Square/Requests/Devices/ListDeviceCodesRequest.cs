using Square.Models.Enums;

namespace Square.Requests.Devices;

/// <summary>
/// The inputs of the ListDeviceCodes operation.
/// </summary>
public sealed record ListDeviceCodesRequest
{
    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this to retrieve the next set of results for your original query.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Paginating results</see> for more information.
    /// </para>
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// If specified, only returns DeviceCodes of the specified location.
    /// Returns DeviceCodes of all locations if empty.
    /// </summary>
    public string? LocationId { get; init; }

    /// <summary>
    /// If specified, only returns DeviceCodes targeting the specified product type.
    /// Returns DeviceCodes of all product types if empty.
    /// </summary>
    public ProductType? ProductType { get; init; }

    /// <summary>
    /// If specified, returns DeviceCodes with the specified statuses.
    /// Returns DeviceCodes of status <c>PAIRED</c> and <c>UNPAIRED</c> if empty.
    /// </summary>
    public DeviceCodeStatus? Status { get; init; }
}

namespace Square.Requests.Devices;

/// <summary>
/// The inputs of the GetDevice operation.
/// </summary>
public sealed record GetDeviceRequest
{
    /// <summary>
    /// The unique ID for the desired <c>Device</c>.
    /// </summary>
    public required string DeviceId { get; init; }
}

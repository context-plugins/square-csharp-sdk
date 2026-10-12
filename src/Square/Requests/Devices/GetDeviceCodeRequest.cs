namespace Square.Requests.Devices;

/// <summary>
/// The inputs of the GetDeviceCode operation.
/// </summary>
public sealed record GetDeviceCodeRequest
{
    /// <summary>
    /// The unique identifier for the device code.
    /// </summary>
    public required string Id { get; init; }
}

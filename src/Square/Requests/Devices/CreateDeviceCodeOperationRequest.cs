using Square.Models;

namespace Square.Requests.Devices;

/// <summary>
/// The inputs of the CreateDeviceCode operation.
/// </summary>
public sealed record CreateDeviceCodeOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateDeviceCodeRequest Body { get; init; }
}

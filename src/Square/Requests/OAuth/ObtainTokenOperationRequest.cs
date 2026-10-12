using Square.Models;

namespace Square.Requests.OAuth;

/// <summary>
/// The inputs of the ObtainToken operation.
/// </summary>
public sealed record ObtainTokenOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required ObtainTokenRequest Body { get; init; }
}

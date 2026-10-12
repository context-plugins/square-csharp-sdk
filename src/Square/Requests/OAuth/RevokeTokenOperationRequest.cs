using Square.Models;

namespace Square.Requests.OAuth;

/// <summary>
/// The inputs of the RevokeToken operation.
/// </summary>
public sealed record RevokeTokenOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required RevokeTokenRequest Body { get; init; }
}

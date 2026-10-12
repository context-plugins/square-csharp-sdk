using Square.Models;

namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the UpdateShift operation.
/// </summary>
public sealed record UpdateShiftOperationRequest
{
    /// <summary>
    /// The ID of the object being updated.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateShiftRequest Body { get; init; }
}

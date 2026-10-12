using Square.Models;

namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the UpdateScheduledShift operation.
/// </summary>
public sealed record UpdateScheduledShiftOperationRequest
{
    /// <summary>
    /// The ID of the scheduled shift to update.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateScheduledShiftRequest Body { get; init; }
}

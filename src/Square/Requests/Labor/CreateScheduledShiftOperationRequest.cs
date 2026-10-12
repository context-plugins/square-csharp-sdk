using Square.Models;

namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the CreateScheduledShift operation.
/// </summary>
public sealed record CreateScheduledShiftOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateScheduledShiftRequest Body { get; init; }
}

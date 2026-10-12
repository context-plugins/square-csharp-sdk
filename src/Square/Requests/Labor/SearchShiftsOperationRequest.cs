using Square.Models;

namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the SearchShifts operation.
/// </summary>
public sealed record SearchShiftsOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required SearchShiftsRequest Body { get; init; }
}

using Square.Models;

namespace Square.Requests.Terminal;

/// <summary>
/// The inputs of the SearchTerminalCheckouts operation.
/// </summary>
public sealed record SearchTerminalCheckoutsOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required SearchTerminalCheckoutsRequest Body { get; init; }
}

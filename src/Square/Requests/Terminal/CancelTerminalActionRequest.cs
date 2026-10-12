namespace Square.Requests.Terminal;

/// <summary>
/// The inputs of the CancelTerminalAction operation.
/// </summary>
public sealed record CancelTerminalActionRequest
{
    /// <summary>
    /// Unique ID for the desired <c>TerminalAction</c>.
    /// </summary>
    public required string ActionId { get; init; }
}

namespace Square.Requests.Terminal;

/// <summary>
/// The inputs of the GetTerminalAction operation.
/// </summary>
public sealed record GetTerminalActionRequest
{
    /// <summary>
    /// Unique ID for the desired <c>TerminalAction</c>.
    /// </summary>
    public required string ActionId { get; init; }
}

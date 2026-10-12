namespace Square.Requests.Terminal;

/// <summary>
/// The inputs of the DismissTerminalAction operation.
/// </summary>
public sealed record DismissTerminalActionRequest
{
    /// <summary>
    /// Unique ID for the <c>TerminalAction</c> associated with the action to be dismissed.
    /// </summary>
    public required string ActionId { get; init; }
}

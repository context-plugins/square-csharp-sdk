namespace Square.Requests.Terminal;

/// <summary>
/// The inputs of the CancelTerminalRefund operation.
/// </summary>
public sealed record CancelTerminalRefundRequest
{
    /// <summary>
    /// The unique ID for the desired <c>TerminalRefund</c>.
    /// </summary>
    public required string TerminalRefundId { get; init; }
}

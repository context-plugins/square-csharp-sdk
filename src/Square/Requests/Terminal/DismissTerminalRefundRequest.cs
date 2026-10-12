namespace Square.Requests.Terminal;

/// <summary>
/// The inputs of the DismissTerminalRefund operation.
/// </summary>
public sealed record DismissTerminalRefundRequest
{
    /// <summary>
    /// Unique ID for the <c>TerminalRefund</c> associated with the refund to be dismissed.
    /// </summary>
    public required string TerminalRefundId { get; init; }
}

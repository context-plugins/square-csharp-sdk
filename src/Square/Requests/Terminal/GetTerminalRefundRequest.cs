namespace Square.Requests.Terminal;

/// <summary>
/// The inputs of the GetTerminalRefund operation.
/// </summary>
public sealed record GetTerminalRefundRequest
{
    /// <summary>
    /// The unique ID for the desired <c>TerminalRefund</c>.
    /// </summary>
    public required string TerminalRefundId { get; init; }
}

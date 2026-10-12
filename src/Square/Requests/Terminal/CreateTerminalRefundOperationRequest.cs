using Square.Models;

namespace Square.Requests.Terminal;

/// <summary>
/// The inputs of the CreateTerminalRefund operation.
/// </summary>
public sealed record CreateTerminalRefundOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateTerminalRefundRequest Body { get; init; }
}

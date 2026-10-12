using Square.Models;

namespace Square.Requests.Refunds;

/// <summary>
/// The inputs of the RefundPayment operation.
/// </summary>
public sealed record RefundPaymentOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required RefundPaymentRequest Body { get; init; }
}

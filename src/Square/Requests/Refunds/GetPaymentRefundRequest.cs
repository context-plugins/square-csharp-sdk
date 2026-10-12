namespace Square.Requests.Refunds;

/// <summary>
/// The inputs of the GetPaymentRefund operation.
/// </summary>
public sealed record GetPaymentRefundRequest
{
    /// <summary>
    /// The unique ID for the desired <c>PaymentRefund</c>.
    /// </summary>
    public required string RefundId { get; init; }
}

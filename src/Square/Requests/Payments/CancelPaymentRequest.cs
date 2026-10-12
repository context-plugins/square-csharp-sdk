namespace Square.Requests.Payments;

/// <summary>
/// The inputs of the CancelPayment operation.
/// </summary>
public sealed record CancelPaymentRequest
{
    /// <summary>
    /// The ID of the payment to cancel.
    /// </summary>
    public required string PaymentId { get; init; }
}

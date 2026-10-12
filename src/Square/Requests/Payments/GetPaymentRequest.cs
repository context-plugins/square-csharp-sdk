namespace Square.Requests.Payments;

/// <summary>
/// The inputs of the GetPayment operation.
/// </summary>
public sealed record GetPaymentRequest
{
    /// <summary>
    /// A unique ID for the desired payment.
    /// </summary>
    public required string PaymentId { get; init; }
}

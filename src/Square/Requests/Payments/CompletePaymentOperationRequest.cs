using Square.Models;

namespace Square.Requests.Payments;

/// <summary>
/// The inputs of the CompletePayment operation.
/// </summary>
public sealed record CompletePaymentOperationRequest
{
    /// <summary>
    /// The unique ID identifying the payment to be completed.
    /// </summary>
    public required string PaymentId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CompletePaymentRequest Body { get; init; }
}

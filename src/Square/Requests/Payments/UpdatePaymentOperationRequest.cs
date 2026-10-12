using Square.Models;

namespace Square.Requests.Payments;

/// <summary>
/// The inputs of the UpdatePayment operation.
/// </summary>
public sealed record UpdatePaymentOperationRequest
{
    /// <summary>
    /// The ID of the payment to update.
    /// </summary>
    public required string PaymentId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdatePaymentRequest Body { get; init; }
}

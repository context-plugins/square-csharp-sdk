using Square.Models;

namespace Square.Requests.Payments;

/// <summary>
/// The inputs of the CreatePayment operation.
/// </summary>
public sealed record CreatePaymentOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreatePaymentRequest Body { get; init; }
}

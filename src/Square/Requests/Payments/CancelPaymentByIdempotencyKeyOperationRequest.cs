using Square.Models;

namespace Square.Requests.Payments;

/// <summary>
/// The inputs of the CancelPaymentByIdempotencyKey operation.
/// </summary>
public sealed record CancelPaymentByIdempotencyKeyOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CancelPaymentByIdempotencyKeyRequest Body { get; init; }
}

using Square.Models;

namespace Square.Requests.CheckoutApi;

/// <summary>
/// The inputs of the UpdatePaymentLink operation.
/// </summary>
public sealed record UpdatePaymentLinkOperationRequest
{
    /// <summary>
    /// The ID of the payment link to update.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdatePaymentLinkRequest Body { get; init; }
}

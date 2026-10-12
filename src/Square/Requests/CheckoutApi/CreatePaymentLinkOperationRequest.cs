using Square.Models;

namespace Square.Requests.CheckoutApi;

/// <summary>
/// The inputs of the CreatePaymentLink operation.
/// </summary>
public sealed record CreatePaymentLinkOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreatePaymentLinkRequest Body { get; init; }
}

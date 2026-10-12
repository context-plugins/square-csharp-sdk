namespace Square.Requests.CheckoutApi;

/// <summary>
/// The inputs of the DeletePaymentLink operation.
/// </summary>
public sealed record DeletePaymentLinkRequest
{
    /// <summary>
    /// The ID of the payment link to delete.
    /// </summary>
    public required string Id { get; init; }
}

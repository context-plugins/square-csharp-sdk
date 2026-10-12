namespace Square.Requests.CheckoutApi;

/// <summary>
/// The inputs of the RetrievePaymentLink operation.
/// </summary>
public sealed record RetrievePaymentLinkRequest
{
    /// <summary>
    /// The ID of link to retrieve.
    /// </summary>
    public required string Id { get; init; }
}

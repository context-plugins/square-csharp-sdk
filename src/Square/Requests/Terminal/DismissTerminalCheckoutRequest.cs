namespace Square.Requests.Terminal;

/// <summary>
/// The inputs of the DismissTerminalCheckout operation.
/// </summary>
public sealed record DismissTerminalCheckoutRequest
{
    /// <summary>
    /// Unique ID for the <c>TerminalCheckout</c> associated with the checkout to be dismissed.
    /// </summary>
    public required string CheckoutId { get; init; }
}

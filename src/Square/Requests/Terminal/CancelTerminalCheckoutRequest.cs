namespace Square.Requests.Terminal;

/// <summary>
/// The inputs of the CancelTerminalCheckout operation.
/// </summary>
public sealed record CancelTerminalCheckoutRequest
{
    /// <summary>
    /// The unique ID for the desired <c>TerminalCheckout</c>.
    /// </summary>
    public required string CheckoutId { get; init; }
}

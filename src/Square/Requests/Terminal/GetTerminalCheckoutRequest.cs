namespace Square.Requests.Terminal;

/// <summary>
/// The inputs of the GetTerminalCheckout operation.
/// </summary>
public sealed record GetTerminalCheckoutRequest
{
    /// <summary>
    /// The unique ID for the desired <c>TerminalCheckout</c>.
    /// </summary>
    public required string CheckoutId { get; init; }
}

using System.Text.Json.Serialization;

namespace Square.Models;

public record TerminalCheckoutCreatedEventObject
{
    /// <summary>
    /// Represents a checkout processed by the Square Terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkout")]
    public TerminalCheckout? Checkout { get; init; }
}

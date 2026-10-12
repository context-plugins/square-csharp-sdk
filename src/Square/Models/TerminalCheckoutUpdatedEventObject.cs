using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record TerminalCheckoutUpdatedEventObject
{
    /// <summary>
    /// Represents a checkout processed by the Square Terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkout")]
    public TerminalCheckout? Checkout { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

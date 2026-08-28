using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Additional details about <c>WALLET</c> type payments with the <c>brand</c> of <c>LIGHTNING</c>.
/// </summary>
public record LightningDetails
{
    /// <summary>
    /// Payment URL for the lightning payment, a.k.a. the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_url")]
    public string? PaymentUrl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record RefundUpdatedEventObject
{
    /// <summary>
    /// Represents a refund of a payment made using Square. Contains information about
    /// the original payment and the amount of money refunded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refund")]
    public PaymentRefund? Refund { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

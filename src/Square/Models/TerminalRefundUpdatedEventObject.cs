using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record TerminalRefundUpdatedEventObject
{
    /// <summary>
    /// Represents a payment refund processed by the Square Terminal. Only supports Interac (Canadian debit network) payment refunds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refund")]
    public TerminalRefund? Refund { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

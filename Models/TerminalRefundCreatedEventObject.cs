using System.Text.Json.Serialization;

namespace Square.Models;

public record TerminalRefundCreatedEventObject
{
    /// <summary>
    /// Represents a payment refund processed by the Square Terminal. Only supports Interac (Canadian debit network) payment refunds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refund")]
    public TerminalRefund? Refund { get; init; }
}

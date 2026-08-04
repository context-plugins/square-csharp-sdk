using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

public record CreateTerminalRefundResponse
{
    /// <summary>
    /// Information about errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents a payment refund processed by the Square Terminal. Only supports Interac (Canadian debit network) payment refunds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refund")]
    public TerminalRefund? Refund { get; init; }
}

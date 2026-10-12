using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record PaymentBalanceActivityFeeDetail
{
    /// <summary>
    /// The ID of the payment associated with this activity
    /// This will only be populated when a principal LedgerEntryToken is also populated.
    /// If the fee is independent (there is no principal LedgerEntryToken) then this will likely not
    /// be populated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_id")]
    public string? PaymentId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

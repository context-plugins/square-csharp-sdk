using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record PaymentBalanceActivityDepositFeeReversedDetail
{
    /// <summary>
    /// The ID of the payout that triggered this deposit fee activity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payout_id")]
    public string? PayoutId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

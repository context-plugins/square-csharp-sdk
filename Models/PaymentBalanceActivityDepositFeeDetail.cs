using System.Text.Json.Serialization;

namespace Square.Models;

public record PaymentBalanceActivityDepositFeeDetail
{
    /// <summary>
    /// The ID of the payout that triggered this deposit fee activity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payout_id")]
    public string? PayoutId { get; init; }
}

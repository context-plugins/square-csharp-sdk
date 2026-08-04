using System.Text.Json.Serialization;

namespace Square.Models;

public record PaymentBalanceActivitySquareCapitalPaymentDetail
{
    /// <summary>
    /// The ID of the payment associated with this activity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_id")]
    public string? PaymentId { get; init; }
}

using System.Text.Json.Serialization;

namespace Square.Models;

public record AcceptedPaymentMethods
{
    /// <summary>
    /// Whether Apple Pay is accepted at checkout.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("apple_pay")]
    public bool? ApplePay { get; init; }

    /// <summary>
    /// Whether Google Pay is accepted at checkout.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("google_pay")]
    public bool? GooglePay { get; init; }

    /// <summary>
    /// Whether Cash App Pay is accepted at checkout.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash_app_pay")]
    public bool? CashAppPay { get; init; }

    /// <summary>
    /// Whether Afterpay/Clearpay is accepted at checkout.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("afterpay_clearpay")]
    public bool? AfterpayClearpay { get; init; }
}

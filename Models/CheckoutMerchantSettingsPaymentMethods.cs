using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record CheckoutMerchantSettingsPaymentMethods
{
    /// <summary>
    /// The settings allowed for a payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("apple_pay")]
    public CheckoutMerchantSettingsPaymentMethodsPaymentMethod? ApplePay { get; init; }

    /// <summary>
    /// The settings allowed for a payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("google_pay")]
    public CheckoutMerchantSettingsPaymentMethodsPaymentMethod? GooglePay { get; init; }

    /// <summary>
    /// The settings allowed for a payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash_app")]
    public CheckoutMerchantSettingsPaymentMethodsPaymentMethod? CashApp { get; init; }

    /// <summary>
    /// The settings allowed for AfterpayClearpay.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("afterpay_clearpay")]
    public CheckoutMerchantSettingsPaymentMethodsAfterpayClearpay? AfterpayClearpay { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

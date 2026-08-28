using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// The settings allowed for AfterpayClearpay.
/// </summary>
public record CheckoutMerchantSettingsPaymentMethodsAfterpayClearpay
{
    /// <summary>
    /// A range of purchase price that qualifies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_eligibility_range")]
    public CheckoutMerchantSettingsPaymentMethodsAfterpayClearpayEligibilityRange? OrderEligibilityRange { get; init; }

    /// <summary>
    /// A range of purchase price that qualifies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_eligibility_range")]
    public CheckoutMerchantSettingsPaymentMethodsAfterpayClearpayEligibilityRange? ItemEligibilityRange { get; init; }

    /// <summary>
    /// Indicates whether the payment method is enabled for the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

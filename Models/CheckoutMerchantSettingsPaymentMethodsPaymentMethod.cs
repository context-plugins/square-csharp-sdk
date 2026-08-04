using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// The settings allowed for a payment method.
/// </summary>
public record CheckoutMerchantSettingsPaymentMethodsPaymentMethod
{
    /// <summary>
    /// Indicates whether the payment method is enabled for the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }
}

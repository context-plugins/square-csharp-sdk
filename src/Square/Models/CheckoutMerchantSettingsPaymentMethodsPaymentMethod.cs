using System.Text.Json.Serialization;
using Square.Core.Models;

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

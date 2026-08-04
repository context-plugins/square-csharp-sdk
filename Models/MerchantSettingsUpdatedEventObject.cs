using System.Text.Json.Serialization;

namespace Square.Models;

public record MerchantSettingsUpdatedEventObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_settings")]
    public CheckoutMerchantSettings? MerchantSettings { get; init; }
}

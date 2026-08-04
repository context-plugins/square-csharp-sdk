using System.Text.Json.Serialization;

namespace Square.Models;

public record UpdateMerchantSettingsRequest
{
    [JsonPropertyName("merchant_settings")]
    public required CheckoutMerchantSettings MerchantSettings { get; init; }
}

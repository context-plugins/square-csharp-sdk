using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record UpdateMerchantSettingsRequest
{
    [JsonPropertyName("merchant_settings")]
    public required CheckoutMerchantSettings MerchantSettings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

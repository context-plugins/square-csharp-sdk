using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record MerchantSettingsUpdatedEventObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_settings")]
    public CheckoutMerchantSettings? MerchantSettings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

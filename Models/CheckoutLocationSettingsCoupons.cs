using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record CheckoutLocationSettingsCoupons
{
    /// <summary>
    /// Indicates whether coupons are enabled for this location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

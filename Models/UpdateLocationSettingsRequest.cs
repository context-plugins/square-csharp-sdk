using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record UpdateLocationSettingsRequest
{
    [JsonPropertyName("location_settings")]
    public required CheckoutLocationSettings LocationSettings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

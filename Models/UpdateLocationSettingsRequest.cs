using System.Text.Json.Serialization;

namespace Square.Models;

public record UpdateLocationSettingsRequest
{
    [JsonPropertyName("location_settings")]
    public required CheckoutLocationSettings LocationSettings { get; init; }
}

using System.Text.Json.Serialization;

namespace Square.Models;

public record LocationSettingsUpdatedEventObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_settings")]
    public CheckoutLocationSettings? LocationSettings { get; init; }
}

using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record LocationSettingsUpdatedEventObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_settings")]
    public CheckoutLocationSettings? LocationSettings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

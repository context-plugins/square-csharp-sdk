using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

public record DeviceComponentDetailsBatteryDetails
{
    /// <summary>
    /// The battery charge percentage as displayed on the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visible_percent")]
    public int? VisiblePercent { get; init; }

    /// <summary>
    /// An enum for ExternalPower.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("external_power")]
    public DeviceComponentDetailsExternalPower? ExternalPower { get; init; }
}

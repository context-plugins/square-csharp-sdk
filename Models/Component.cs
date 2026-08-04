using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// The wrapper object for the component entries of a given component type.
/// </summary>
public record Component
{
    /// <summary>
    /// An enum for ComponentType.
    /// </summary>
    [JsonPropertyName("type")]
    public required ComponentComponentType Type { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("application_details")]
    public DeviceComponentDetailsApplicationDetails? ApplicationDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card_reader_details")]
    public DeviceComponentDetailsCardReaderDetails? CardReaderDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("battery_details")]
    public DeviceComponentDetailsBatteryDetails? BatteryDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wifi_details")]
    public DeviceComponentDetailsWiFiDetails? WifiDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ethernet_details")]
    public DeviceComponentDetailsEthernetDetails? EthernetDetails { get; init; }
}

using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record DeviceComponentDetailsWiFiDetails
{
    /// <summary>
    /// A boolean to represent whether the WiFI interface is currently active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }

    /// <summary>
    /// The name of the connected WIFI network.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ssid")]
    public string? Ssid { get; init; }

    /// <summary>
    /// The string representation of the device’s IPv4 address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ip_address_v4")]
    public string? IpAddressV4 { get; init; }

    /// <summary>
    /// The security protocol for a secure connection (e.g. WPA2). None provided if the connection
    /// is unsecured.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secure_connection")]
    public string? SecureConnection { get; init; }

    /// <summary>
    /// A value qualified by unit of measure.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signal_strength")]
    public DeviceComponentDetailsMeasurement? SignalStrength { get; init; }

    /// <summary>
    /// The mac address of the device in this network.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mac_address")]
    public string? MacAddress { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

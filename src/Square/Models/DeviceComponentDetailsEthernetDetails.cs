using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record DeviceComponentDetailsEthernetDetails
{
    /// <summary>
    /// A boolean to represent whether the Ethernet interface is currently active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }

    /// <summary>
    /// The string representation of the device’s IPv4 address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ip_address_v4")]
    public string? IpAddressV4 { get; init; }

    /// <summary>
    /// The mac address of the device in this network.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mac_address")]
    public string? MacAddress { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

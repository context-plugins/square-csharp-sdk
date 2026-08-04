using System.Text.Json.Serialization;

namespace Square.Models;

public record DeviceMetadata
{
    /// <summary>
    /// The Terminal’s remaining battery percentage, between 1-100.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("battery_percentage")]
    public string? BatteryPercentage { get; init; }

    /// <summary>
    /// The current charging state of the Terminal.
    /// Options: <c>CHARGING</c>, <c>NOT_CHARGING</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("charging_state")]
    public string? ChargingState { get; init; }

    /// <summary>
    /// The ID of the Square seller business location associated with the Terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// The ID of the Square merchant account that is currently signed-in to the Terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; init; }

    /// <summary>
    /// The Terminal’s current network connection type.
    /// Options: <c>WIFI</c>, <c>ETHERNET</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("network_connection_type")]
    public string? NetworkConnectionType { get; init; }

    /// <summary>
    /// The country in which the Terminal is authorized to take payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_region")]
    public string? PaymentRegion { get; init; }

    /// <summary>
    /// The unique identifier assigned to the Terminal, which can be found on the lower back
    /// of the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serial_number")]
    public string? SerialNumber { get; init; }

    /// <summary>
    /// The current version of the Terminal’s operating system.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("os_version")]
    public string? OsVersion { get; init; }

    /// <summary>
    /// The current version of the application running on the Terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("app_version")]
    public string? AppVersion { get; init; }

    /// <summary>
    /// The name of the Wi-Fi network to which the Terminal is connected.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wifi_network_name")]
    public string? WifiNetworkName { get; init; }

    /// <summary>
    /// The signal strength of the Wi-FI network connection.
    /// Options: <c>POOR</c>, <c>FAIR</c>, <c>GOOD</c>, <c>EXCELLENT</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wifi_network_strength")]
    public string? WifiNetworkStrength { get; init; }

    /// <summary>
    /// The IP address of the Terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ip_address")]
    public string? IpAddress { get; init; }
}

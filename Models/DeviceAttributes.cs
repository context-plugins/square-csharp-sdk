using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

public record DeviceAttributes
{
    /// <summary>
    /// An enum identifier of the device type.
    /// </summary>
    [JsonPropertyName("type")]
    public required DeviceAttributesDeviceType Type { get; init; }

    /// <summary>
    /// The maker of the device.
    /// </summary>
    [JsonPropertyName("manufacturer")]
    public required string Manufacturer { get; init; }

    /// <summary>
    /// The specific model of the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model")]
    public string? Model { get; init; }

    /// <summary>
    /// A seller-specified name for the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The manufacturer-supplied identifier for the device (where available). In many cases,
    /// this identifier will be a serial number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("manufacturers_id")]
    public string? ManufacturersId { get; init; }

    /// <summary>
    /// The RFC 3339-formatted value of the most recent update to the device information.
    /// (Could represent any field update on the device.)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// The current version of software installed on the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public string? Version { get; init; }

    /// <summary>
    /// The merchant_token identifying the merchant controlling the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_token")]
    public string? MerchantToken { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

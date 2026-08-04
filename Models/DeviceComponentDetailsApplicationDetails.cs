using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

public record DeviceComponentDetailsApplicationDetails
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("application_type")]
    public ApplicationType? ApplicationType { get; init; }

    /// <summary>
    /// The version of the application.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public string? Version { get; init; }

    /// <summary>
    /// The location_id of the session for the application.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("session_location")]
    public string? SessionLocation { get; init; }

    /// <summary>
    /// The id of the device code that was used to log in to the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device_code_id")]
    public string? DeviceCodeId { get; init; }
}

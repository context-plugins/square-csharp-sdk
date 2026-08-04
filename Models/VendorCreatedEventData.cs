using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Defines the <c>vendor.created</c> event data structure.
/// </summary>
public record VendorCreatedEventData
{
    /// <summary>
    /// The type of the event data object. The value is <c>vendor</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// The ID of the event data object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object")]
    public VendorCreatedEventObject? Object { get; init; }
}

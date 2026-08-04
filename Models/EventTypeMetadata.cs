using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Contains the metadata of a webhook event type.
/// </summary>
public record EventTypeMetadata
{
    /// <summary>
    /// The event type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event_type")]
    public string? EventType { get; init; }

    /// <summary>
    /// The API version at which the event type was introduced.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("api_version_introduced")]
    public string? ApiVersionIntroduced { get; init; }

    /// <summary>
    /// The release status of the event type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("release_status")]
    public string? ReleaseStatus { get; init; }
}

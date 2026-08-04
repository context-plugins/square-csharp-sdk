using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Contains metadata about a particular <see href="entity:Event">Event</see>.
/// </summary>
public record EventMetadata
{
    /// <summary>
    /// A unique ID for the event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event_id")]
    public string? EventId { get; init; }

    /// <summary>
    /// The API version of the event. This corresponds to the default API version of the developer application at the time when the event was created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("api_version")]
    public string? ApiVersion { get; init; }
}

using System.Text.Json.Serialization;

namespace Square.Models;

public record LocationCreatedEventData
{
    /// <summary>
    /// Name of the affected object’s type, <c>"location"</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// ID of the updated <see href="entity:Location">Location</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }
}

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

public record BookingCreatedEventData
{
    /// <summary>
    /// The type of the event data object. The value is <c>"booking"</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [MaxLength(50)]
    public string? Type { get; init; }

    /// <summary>
    /// The ID of the event data object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(192)]
    public string? Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object")]
    public BookingCreatedEventObject? Object { get; init; }
}

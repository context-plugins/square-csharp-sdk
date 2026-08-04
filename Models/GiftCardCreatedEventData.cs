using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// The data associated with a <c>gift_card.created</c> event.
/// </summary>
public record GiftCardCreatedEventData
{
    /// <summary>
    /// The type of object affected by the event. For this event, the value is <c>gift_card</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// The ID of the new gift card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// An object that contains the gift card associated with a <c>gift_card.created</c> event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object")]
    public GiftCardCreatedEventObject? Object { get; init; }
}

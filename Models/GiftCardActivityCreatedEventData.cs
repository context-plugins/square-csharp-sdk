using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents the data associated with a <c>gift_card.activity.created</c> event.
/// </summary>
public record GiftCardActivityCreatedEventData
{
    /// <summary>
    /// The type of object affected by the event. For this event, the value is <c>gift_card_activity</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// The ID of the new gift card activity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// An object that contains the gift card activity associated with a
    /// <c>gift_card.activity.created</c> event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object")]
    public GiftCardActivityCreatedEventObject? Object { get; init; }
}

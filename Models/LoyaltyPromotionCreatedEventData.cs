using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// The data associated with a <c>loyalty.promotion.created</c> event.
/// </summary>
public record LoyaltyPromotionCreatedEventData
{
    /// <summary>
    /// The type of object affected by the event. For this event, the value is <c>loyalty_promotion</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// The ID of the affected loyalty promotion.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// An object that contains the loyalty promotion associated with a <c>loyalty.promotion.created</c> event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object")]
    public LoyaltyPromotionCreatedEventObject? Object { get; init; }
}

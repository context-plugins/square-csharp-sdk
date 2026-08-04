using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// An object that contains the gift card associated with a <c>gift_card.created</c> event.
/// </summary>
public record GiftCardCreatedEventObject
{
    /// <summary>
    /// Represents a Square gift card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gift_card")]
    public GiftCard? GiftCard { get; init; }
}

using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// An object that contains the gift card activity associated with a
/// <c>gift_card.activity.updated</c> event.
/// </summary>
public record GiftCardActivityUpdatedEventObject
{
    /// <summary>
    /// Represents an action performed on a <see href="entity:GiftCard">gift card</see> that affects its state or balance.
    /// A gift card activity contains information about a specific activity type. For example, a <c>REDEEM</c> activity
    /// includes a <c>redeem_activity_details</c> field that contains information about the redemption.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gift_card_activity")]
    public GiftCardActivity? GiftCardActivity { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

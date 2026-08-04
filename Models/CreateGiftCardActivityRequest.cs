using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// A request to create a gift card activity.
/// </summary>
public record CreateGiftCardActivityRequest
{
    /// <summary>
    /// A unique string that identifies the <c>CreateGiftCardActivity</c> request.
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// Represents an action performed on a <see href="entity:GiftCard">gift card</see> that affects its state or balance.
    /// A gift card activity contains information about a specific activity type. For example, a <c>REDEEM</c> activity
    /// includes a <c>redeem_activity_details</c> field that contains information about the redemption.
    /// </summary>
    [JsonPropertyName("gift_card_activity")]
    public required GiftCardActivity GiftCardActivity { get; init; }
}

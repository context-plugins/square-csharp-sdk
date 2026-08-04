using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:GiftCards-CreateGiftCard">CreateGiftCard</see> request.
/// </summary>
public record CreateGiftCardRequest
{
    /// <summary>
    /// A unique identifier for this request, used to ensure idempotency. For more information,
    /// see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">Idempotency</see>.
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:Location">location</see> where the gift card should be registered for
    /// reporting purposes. Gift cards can be redeemed at any of the seller's locations.
    /// </summary>
    [JsonPropertyName("location_id")]
    [MinLength(1)]
    public required string LocationId { get; init; }

    /// <summary>
    /// Represents a Square gift card.
    /// </summary>
    [JsonPropertyName("gift_card")]
    public required GiftCard GiftCard { get; init; }
}

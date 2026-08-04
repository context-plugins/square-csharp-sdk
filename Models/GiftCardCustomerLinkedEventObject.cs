using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// An object that contains the gift card and customer ID associated with a
/// <c>gift_card.customer_linked</c> event.
/// </summary>
public record GiftCardCustomerLinkedEventObject
{
    /// <summary>
    /// Represents a Square gift card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gift_card")]
    public GiftCard? GiftCard { get; init; }

    /// <summary>
    /// The ID of the linked <see href="entity:Customer">customer</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("linked_customer_id")]
    public string? LinkedCustomerId { get; init; }
}

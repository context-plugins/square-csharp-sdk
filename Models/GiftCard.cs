using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a Square gift card.
/// </summary>
public record GiftCard
{
    /// <summary>
    /// The Square-assigned ID of the gift card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Indicates the gift card type.
    /// </summary>
    [JsonPropertyName("type")]
    public required GiftCardType Type { get; init; }

    /// <summary>
    /// Indicates the source that generated the gift card
    /// account number (GAN).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gan_source")]
    public GiftCardGansource? GanSource { get; init; }

    /// <summary>
    /// Indicates the gift card state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public GiftCardStatus? State { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balance_money")]
    public Money? BalanceMoney { get; init; }

    /// <summary>
    /// The gift card account number (GAN). Buyers can use the GAN to make purchases or check
    /// the gift card balance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gan")]
    public string? Gan { get; init; }

    /// <summary>
    /// The timestamp when the gift card was created, in RFC 3339 format.
    /// In the case of a digital gift card, it is the time when you create a card
    /// (using the Square Point of Sale application, Seller Dashboard, or Gift Cards API).
    /// In the case of a plastic gift card, it is the time when Square associates the card with the
    /// seller at the time of activation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The IDs of the <see href="entity:Customer">customer profiles</see> to whom this gift card is linked.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_ids")]
    public IReadOnlyList<string>? CustomerIds { get; init; }
}

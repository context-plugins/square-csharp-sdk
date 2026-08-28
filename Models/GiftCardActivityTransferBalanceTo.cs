using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents details about a <c>TRANSFER_BALANCE_TO</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
/// </summary>
public record GiftCardActivityTransferBalanceTo
{
    /// <summary>
    /// The ID of the gift card from which the specified amount was transferred.
    /// </summary>
    [JsonPropertyName("transfer_from_gift_card_id")]
    public required string TransferFromGiftCardId { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonPropertyName("amount_money")]
    public required Money AmountMoney { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents details about an <c>IMPORT</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
/// This activity type is used when Square imports a third-party gift card, in which case the
/// <c>gan_source</c> of the gift card is set to <c>OTHER</c>.
/// </summary>
public record GiftCardActivityImport
{
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
}

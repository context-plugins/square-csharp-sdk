using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Describes an ad hoc item and price to generate a quick pay checkout link.
/// For more information,
/// see <see href="https://developer.squareup.com/docs/checkout-api/quick-pay-checkout">Quick Pay Checkout</see>.
/// </summary>
public record QuickPay
{
    /// <summary>
    /// The ad hoc item name. In the resulting <c>Order</c>, this name appears as the line item name.
    /// </summary>
    [JsonPropertyName("name")]
    [StringLength(255, MinimumLength = 1)]
    public required string Name { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonPropertyName("price_money")]
    public required Money PriceMoney { get; init; }

    /// <summary>
    /// The ID of the business location the checkout is associated with.
    /// </summary>
    [JsonPropertyName("location_id")]
    public required string LocationId { get; init; }
}

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents an applied portion of a tax to a line item in an order.
/// <para>
/// Order-scoped taxes automatically include the applied taxes in each line item.
/// Line item taxes must be referenced from any applicable line items.
/// The corresponding applied money is automatically computed, based on the
/// set of participating line items.
/// </para>
/// </summary>
public record OrderLineItemAppliedTax
{
    /// <summary>
    /// A unique ID that identifies the applied tax only within this order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    [MaxLength(60)]
    public string? Uid { get; init; }

    /// <summary>
    /// The <c>uid</c> of the tax for which this applied tax represents. It must reference
    /// a tax present in the <c>order.taxes</c> field.
    /// <para>
    /// This field is immutable. To change which taxes apply to a line item, delete and add a new
    /// <c>OrderLineItemAppliedTax</c>.
    /// </para>
    /// </summary>
    [JsonPropertyName("tax_uid")]
    [StringLength(60, MinimumLength = 1)]
    public required string TaxUid { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applied_money")]
    public Money? AppliedMoney { get; init; }

    /// <summary>
    /// Indicates whether the tax was automatically applied to the order based on
    /// the catalog configuration. For an example, see
    /// <see href="https://developer.squareup.com/docs/orders-api/apply-taxes-and-discounts/auto-apply-taxes">Automatically Apply Taxes to an Order</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auto_applied")]
    public bool? AutoApplied { get; init; }
}

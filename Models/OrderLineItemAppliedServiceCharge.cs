using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

public record OrderLineItemAppliedServiceCharge
{
    /// <summary>
    /// A unique ID that identifies the applied service charge only within this order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    [MaxLength(60)]
    public string? Uid { get; init; }

    /// <summary>
    /// The <c>uid</c> of the service charge that the applied service charge represents. It must
    /// reference a service charge present in the <c>order.service_charges</c> field.
    /// <para>
    /// This field is immutable. To change which service charges apply to a line item,
    /// delete and add a new <c>OrderLineItemAppliedServiceCharge</c>.
    /// </para>
    /// </summary>
    [JsonPropertyName("service_charge_uid")]
    [StringLength(60, MinimumLength = 1)]
    public required string ServiceChargeUid { get; init; }

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
}

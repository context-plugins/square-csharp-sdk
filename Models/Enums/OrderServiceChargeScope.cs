using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates whether this is a line-item or order-level apportioned
/// service charge.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderServiceChargeScope>))]
public sealed record OrderServiceChargeScope : StringEnum<OrderServiceChargeScope>
{
    private OrderServiceChargeScope(string value) : base(value)
    {
    }

    /// <summary>
    /// Used for reporting only.
    /// The original transaction service charge scope is currently not supported by the API.
    /// </summary>
    public static readonly OrderServiceChargeScope OtherServiceChargeScope = new("OTHER_SERVICE_CHARGE_SCOPE");

    /// <summary>
    /// The service charge should be applied to only line items specified by
    /// <c>OrderLineItemAppliedServiceCharge</c> reference records.
    /// </summary>
    public static readonly OrderServiceChargeScope LineItem = new("LINE_ITEM");

    /// <summary>
    /// The service charge should be applied to the entire order.
    /// </summary>
    public static readonly OrderServiceChargeScope Order = new("ORDER");

    public static OrderServiceChargeScope FromValue(string value) => FromValueCore(value);
}

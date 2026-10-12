using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates whether this is a line-item or order-level apportioned
/// service charge.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderServiceChargeScope>))]
public sealed record OrderServiceChargeScope : OpenStringEnum<OrderServiceChargeScope>
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

    public TResult Match<TResult>(Func<TResult> onOtherServiceChargeScope,
        Func<TResult> onLineItem,
        Func<TResult> onOrder,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == OtherServiceChargeScope => onOtherServiceChargeScope(),
            _ when this == LineItem => onLineItem(),
            _ when this == Order => onOrder(),
            _ => otherwise(Value)
        };

    public void Match(Action onOtherServiceChargeScope, Action onLineItem, Action onOrder, Action<string> otherwise)
    {
        if (this == OtherServiceChargeScope) onOtherServiceChargeScope();
        else if (this == LineItem) onLineItem();
        else if (this == Order) onOrder();
        else otherwise(Value);
    }
}

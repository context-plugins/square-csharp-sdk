using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates whether this is a line-item or order-level discount.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderLineItemDiscountScope>))]
public sealed record OrderLineItemDiscountScope : OpenStringEnum<OrderLineItemDiscountScope>
{
    private OrderLineItemDiscountScope(string value) : base(value)
    {
    }

    /// <summary>
    /// Used for reporting only.
    /// The original transaction discount scope is currently not supported by the API.
    /// </summary>
    public static readonly OrderLineItemDiscountScope OtherDiscountScope = new("OTHER_DISCOUNT_SCOPE");

    /// <summary>
    /// The discount should be applied to only line items specified by
    /// <c>OrderLineItemAppliedDiscount</c> reference records.
    /// </summary>
    public static readonly OrderLineItemDiscountScope LineItem = new("LINE_ITEM");

    /// <summary>
    /// The discount should be applied to the entire order.
    /// </summary>
    public static readonly OrderLineItemDiscountScope Order = new("ORDER");

    public TResult Match<TResult>(Func<TResult> onOtherDiscountScope,
        Func<TResult> onLineItem,
        Func<TResult> onOrder,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == OtherDiscountScope => onOtherDiscountScope(),
            _ when this == LineItem => onLineItem(),
            _ when this == Order => onOrder(),
            _ => otherwise(Value)
        };

    public void Match(Action onOtherDiscountScope, Action onLineItem, Action onOrder, Action<string> otherwise)
    {
        if (this == OtherDiscountScope) onOtherDiscountScope();
        else if (this == LineItem) onLineItem();
        else if (this == Order) onOrder();
        else otherwise(Value);
    }
}

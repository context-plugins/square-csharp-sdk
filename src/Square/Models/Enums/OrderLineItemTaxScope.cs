using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates whether this is a line-item or order-level tax.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderLineItemTaxScope>))]
public sealed record OrderLineItemTaxScope : OpenStringEnum<OrderLineItemTaxScope>
{
    private OrderLineItemTaxScope(string value) : base(value)
    {
    }

    /// <summary>
    /// Used for reporting only.
    /// The original transaction tax scope is currently not supported by the API.
    /// </summary>
    public static readonly OrderLineItemTaxScope OtherTaxScope = new("OTHER_TAX_SCOPE");

    /// <summary>
    /// The tax should be applied only to line items specified by
    /// the <c>OrderLineItemAppliedTax</c> reference records.
    /// </summary>
    public static readonly OrderLineItemTaxScope LineItem = new("LINE_ITEM");

    /// <summary>
    /// The tax should be applied to the entire order.
    /// </summary>
    public static readonly OrderLineItemTaxScope Order = new("ORDER");

    public TResult Match<TResult>(Func<TResult> onOtherTaxScope,
        Func<TResult> onLineItem,
        Func<TResult> onOrder,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == OtherTaxScope => onOtherTaxScope(),
            _ when this == LineItem => onLineItem(),
            _ when this == Order => onOrder(),
            _ => otherwise(Value)
        };

    public void Match(Action onOtherTaxScope, Action onLineItem, Action onOrder, Action<string> otherwise)
    {
        if (this == OtherTaxScope) onOtherTaxScope();
        else if (this == LineItem) onLineItem();
        else if (this == Order) onOrder();
        else otherwise(Value);
    }
}

using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates how the discount is applied to the associated line item or order.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderLineItemDiscountType>))]
public sealed record OrderLineItemDiscountType : OpenStringEnum<OrderLineItemDiscountType>
{
    private OrderLineItemDiscountType(string value) : base(value)
    {
    }

    /// <summary>
    /// Used for reporting only.
    /// The original transaction discount type is currently not supported by the API.
    /// </summary>
    public static readonly OrderLineItemDiscountType UnknownDiscount = new("UNKNOWN_DISCOUNT");

    /// <summary>
    /// Apply the discount as a fixed percentage (such as 5%) off the item price.
    /// </summary>
    public static readonly OrderLineItemDiscountType FixedPercentage = new("FIXED_PERCENTAGE");

    /// <summary>
    /// Apply the discount as a fixed monetary value (such as $1.00) off the item price.
    /// </summary>
    public static readonly OrderLineItemDiscountType FixedAmount = new("FIXED_AMOUNT");

    /// <summary>
    /// Apply the discount as a variable percentage based on the item
    /// price.
    /// <para>
    /// The specific discount percentage of a <c>VARIABLE_PERCENTAGE</c> discount
    /// is assigned at the time of the purchase.
    /// </para>
    /// </summary>
    public static readonly OrderLineItemDiscountType VariablePercentage = new("VARIABLE_PERCENTAGE");

    /// <summary>
    /// Apply the discount as a variable amount based on the item price.
    /// <para>
    /// The specific discount amount of a <c>VARIABLE_AMOUNT</c> discount
    /// is assigned at the time of the purchase.
    /// </para>
    /// </summary>
    public static readonly OrderLineItemDiscountType VariableAmount = new("VARIABLE_AMOUNT");

    public TResult Match<TResult>(Func<TResult> onUnknownDiscount,
        Func<TResult> onFixedPercentage,
        Func<TResult> onFixedAmount,
        Func<TResult> onVariablePercentage,
        Func<TResult> onVariableAmount,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == UnknownDiscount => onUnknownDiscount(),
            _ when this == FixedPercentage => onFixedPercentage(),
            _ when this == FixedAmount => onFixedAmount(),
            _ when this == VariablePercentage => onVariablePercentage(),
            _ when this == VariableAmount => onVariableAmount(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknownDiscount,
        Action onFixedPercentage,
        Action onFixedAmount,
        Action onVariablePercentage,
        Action onVariableAmount,
        Action<string> otherwise)
    {
        if (this == UnknownDiscount) onUnknownDiscount();
        else if (this == FixedPercentage) onFixedPercentage();
        else if (this == FixedAmount) onFixedAmount();
        else if (this == VariablePercentage) onVariablePercentage();
        else if (this == VariableAmount) onVariableAmount();
        else otherwise(Value);
    }
}

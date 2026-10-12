using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// How to apply a CatalogDiscount to a CatalogItem.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogDiscountType>))]
public sealed record CatalogDiscountType : OpenStringEnum<CatalogDiscountType>
{
    private CatalogDiscountType(string value) : base(value)
    {
    }

    /// <summary>
    /// Apply the discount as a fixed percentage (e.g., 5%) off the item price.
    /// </summary>
    public static readonly CatalogDiscountType FixedPercentage = new("FIXED_PERCENTAGE");

    /// <summary>
    /// Apply the discount as a fixed amount (e.g., $1.00) off the item price.
    /// </summary>
    public static readonly CatalogDiscountType FixedAmount = new("FIXED_AMOUNT");

    /// <summary>
    /// Apply the discount as a variable percentage off the item price. The percentage will be specified at the time of sale.
    /// </summary>
    public static readonly CatalogDiscountType VariablePercentage = new("VARIABLE_PERCENTAGE");

    /// <summary>
    /// Apply the discount as a variable amount off the item price. The amount will be specified at the time of sale.
    /// </summary>
    public static readonly CatalogDiscountType VariableAmount = new("VARIABLE_AMOUNT");

    public TResult Match<TResult>(Func<TResult> onFixedPercentage,
        Func<TResult> onFixedAmount,
        Func<TResult> onVariablePercentage,
        Func<TResult> onVariableAmount,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FixedPercentage => onFixedPercentage(),
            _ when this == FixedAmount => onFixedAmount(),
            _ when this == VariablePercentage => onVariablePercentage(),
            _ when this == VariableAmount => onVariableAmount(),
            _ => otherwise(Value)
        };

    public void Match(Action onFixedPercentage,
        Action onFixedAmount,
        Action onVariablePercentage,
        Action onVariableAmount,
        Action<string> otherwise)
    {
        if (this == FixedPercentage) onFixedPercentage();
        else if (this == FixedAmount) onFixedAmount();
        else if (this == VariablePercentage) onVariablePercentage();
        else if (this == VariableAmount) onVariableAmount();
        else otherwise(Value);
    }
}

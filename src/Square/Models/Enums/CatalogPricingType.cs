using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates whether the price of a CatalogItemVariation should be entered manually at the time of sale.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogPricingType>))]
public sealed record CatalogPricingType : OpenStringEnum<CatalogPricingType>
{
    private CatalogPricingType(string value) : base(value)
    {
    }

    /// <summary>
    /// The catalog item variation's price is fixed.
    /// </summary>
    public static readonly CatalogPricingType FixedPricing = new("FIXED_PRICING");

    /// <summary>
    /// The catalog item variation's price is entered at the time of sale.
    /// </summary>
    public static readonly CatalogPricingType VariablePricing = new("VARIABLE_PRICING");

    public TResult Match<TResult>(Func<TResult> onFixedPricing,
        Func<TResult> onVariablePricing,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FixedPricing => onFixedPricing(),
            _ when this == VariablePricing => onVariablePricing(),
            _ => otherwise(Value)
        };

    public void Match(Action onFixedPricing, Action onVariablePricing, Action<string> otherwise)
    {
        if (this == FixedPricing) onFixedPricing();
        else if (this == VariablePricing) onVariablePricing();
        else otherwise(Value);
    }
}

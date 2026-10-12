using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The type of dietary preference for the <c>FOOD_AND_BEV</c> type of items and integredients.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogItemFoodAndBeverageDetailsDietaryPreferenceType>))]
public sealed record CatalogItemFoodAndBeverageDetailsDietaryPreferenceType : OpenStringEnum<CatalogItemFoodAndBeverageDetailsDietaryPreferenceType>
{
    private CatalogItemFoodAndBeverageDetailsDietaryPreferenceType(string value) : base(value)
    {
    }

    /// <summary>
    /// A standard value from a pre-determined list.
    /// </summary>
    public static readonly CatalogItemFoodAndBeverageDetailsDietaryPreferenceType Standard = new("STANDARD");

    /// <summary>
    /// A user-defined custom value.
    /// </summary>
    public static readonly CatalogItemFoodAndBeverageDetailsDietaryPreferenceType Custom = new("CUSTOM");

    public TResult Match<TResult>(Func<TResult> onStandard, Func<TResult> onCustom, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Standard => onStandard(),
            _ when this == Custom => onCustom(),
            _ => otherwise(Value)
        };

    public void Match(Action onStandard, Action onCustom, Action<string> otherwise)
    {
        if (this == Standard) onStandard();
        else if (this == Custom) onCustom();
        else otherwise(Value);
    }
}

using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The type of dietary preference for the <c>FOOD_AND_BEV</c> type of items and integredients.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogItemFoodAndBeverageDetailsDietaryPreferenceType>))]
public sealed record CatalogItemFoodAndBeverageDetailsDietaryPreferenceType : StringEnum<CatalogItemFoodAndBeverageDetailsDietaryPreferenceType>
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

    public static CatalogItemFoodAndBeverageDetailsDietaryPreferenceType FromValue(string value) =>
        FromValueCore(value);
}

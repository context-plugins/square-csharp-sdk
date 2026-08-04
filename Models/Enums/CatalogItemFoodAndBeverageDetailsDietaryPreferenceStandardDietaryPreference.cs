using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Standard dietary preferences for food and beverage items that are recommended on item creation.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference>))]
public sealed record CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference : StringEnum<CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference>
{
    private CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference(string value) : base(value)
    {
    }

    public static readonly CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference DairyFree = new("DAIRY_FREE");

    public static readonly CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference GlutenFree = new("GLUTEN_FREE");

    public static readonly CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference Halal = new("HALAL");

    public static readonly CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference Kosher = new("KOSHER");

    public static readonly CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference NutFree = new("NUT_FREE");

    public static readonly CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference Vegan = new("VEGAN");

    public static readonly CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference Vegetarian = new("VEGETARIAN");

    public static CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference FromValue(string value) =>
        FromValueCore(value);
}

using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Standard dietary preferences for food and beverage items that are recommended on item creation.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference>))]
public sealed record CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference : OpenStringEnum<CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference>
{
    private CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference(string value) : base(value)
    {
    }

    public static readonly CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference DairyFree = new(
        "DAIRY_FREE");

    public static readonly CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference GlutenFree = new(
        "GLUTEN_FREE");

    public static readonly CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference Halal = new(
        "HALAL");

    public static readonly CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference Kosher = new(
        "KOSHER");

    public static readonly CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference NutFree = new(
        "NUT_FREE");

    public static readonly CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference Vegan = new(
        "VEGAN");

    public static readonly CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference Vegetarian = new(
        "VEGETARIAN");

    public TResult Match<TResult>(Func<TResult> onDairyFree,
        Func<TResult> onGlutenFree,
        Func<TResult> onHalal,
        Func<TResult> onKosher,
        Func<TResult> onNutFree,
        Func<TResult> onVegan,
        Func<TResult> onVegetarian,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DairyFree => onDairyFree(),
            _ when this == GlutenFree => onGlutenFree(),
            _ when this == Halal => onHalal(),
            _ when this == Kosher => onKosher(),
            _ when this == NutFree => onNutFree(),
            _ when this == Vegan => onVegan(),
            _ when this == Vegetarian => onVegetarian(),
            _ => otherwise(Value)
        };

    public void Match(Action onDairyFree,
        Action onGlutenFree,
        Action onHalal,
        Action onKosher,
        Action onNutFree,
        Action onVegan,
        Action onVegetarian,
        Action<string> otherwise)
    {
        if (this == DairyFree) onDairyFree();
        else if (this == GlutenFree) onGlutenFree();
        else if (this == Halal) onHalal();
        else if (this == Kosher) onKosher();
        else if (this == NutFree) onNutFree();
        else if (this == Vegan) onVegan();
        else if (this == Vegetarian) onVegetarian();
        else otherwise(Value);
    }
}

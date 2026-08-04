using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Standard ingredients for food and beverage items that are recommended on item creation.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient>))]
public sealed record CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient : StringEnum<CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient>
{
    private CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient(string value) : base(value)
    {
    }

    public static readonly CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient Celery = new("CELERY");

    public static readonly CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient Crustaceans = new("CRUSTACEANS");

    public static readonly CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient Eggs = new("EGGS");

    public static readonly CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient Fish = new("FISH");

    public static readonly CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient Gluten = new("GLUTEN");

    public static readonly CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient Lupin = new("LUPIN");

    public static readonly CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient Milk = new("MILK");

    public static readonly CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient Molluscs = new("MOLLUSCS");

    public static readonly CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient Mustard = new("MUSTARD");

    public static readonly CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient Peanuts = new("PEANUTS");

    public static readonly CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient Sesame = new("SESAME");

    public static readonly CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient Soy = new("SOY");

    public static readonly CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient Sulphites = new("SULPHITES");

    public static readonly CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient TreeNuts = new("TREE_NUTS");

    public static CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient FromValue(string value) =>
        FromValueCore(value);
}

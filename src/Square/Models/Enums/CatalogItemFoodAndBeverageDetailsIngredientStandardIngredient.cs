using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Standard ingredients for food and beverage items that are recommended on item creation.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient>))]
public sealed record CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient : OpenStringEnum<CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient>
{
    private CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient(string value) : base(value)
    {
    }

    public static readonly CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient Celery = new("CELERY");

    public static readonly CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient Crustaceans = new(
        "CRUSTACEANS");

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

    public TResult Match<TResult>(Func<TResult> onCelery,
        Func<TResult> onCrustaceans,
        Func<TResult> onEggs,
        Func<TResult> onFish,
        Func<TResult> onGluten,
        Func<TResult> onLupin,
        Func<TResult> onMilk,
        Func<TResult> onMolluscs,
        Func<TResult> onMustard,
        Func<TResult> onPeanuts,
        Func<TResult> onSesame,
        Func<TResult> onSoy,
        Func<TResult> onSulphites,
        Func<TResult> onTreeNuts,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Celery => onCelery(),
            _ when this == Crustaceans => onCrustaceans(),
            _ when this == Eggs => onEggs(),
            _ when this == Fish => onFish(),
            _ when this == Gluten => onGluten(),
            _ when this == Lupin => onLupin(),
            _ when this == Milk => onMilk(),
            _ when this == Molluscs => onMolluscs(),
            _ when this == Mustard => onMustard(),
            _ when this == Peanuts => onPeanuts(),
            _ when this == Sesame => onSesame(),
            _ when this == Soy => onSoy(),
            _ when this == Sulphites => onSulphites(),
            _ when this == TreeNuts => onTreeNuts(),
            _ => otherwise(Value)
        };

    public void Match(Action onCelery,
        Action onCrustaceans,
        Action onEggs,
        Action onFish,
        Action onGluten,
        Action onLupin,
        Action onMilk,
        Action onMolluscs,
        Action onMustard,
        Action onPeanuts,
        Action onSesame,
        Action onSoy,
        Action onSulphites,
        Action onTreeNuts,
        Action<string> otherwise)
    {
        if (this == Celery) onCelery();
        else if (this == Crustaceans) onCrustaceans();
        else if (this == Eggs) onEggs();
        else if (this == Fish) onFish();
        else if (this == Gluten) onGluten();
        else if (this == Lupin) onLupin();
        else if (this == Milk) onMilk();
        else if (this == Molluscs) onMolluscs();
        else if (this == Mustard) onMustard();
        else if (this == Peanuts) onPeanuts();
        else if (this == Sesame) onSesame();
        else if (this == Soy) onSoy();
        else if (this == Sulphites) onSulphites();
        else if (this == TreeNuts) onTreeNuts();
        else otherwise(Value);
    }
}

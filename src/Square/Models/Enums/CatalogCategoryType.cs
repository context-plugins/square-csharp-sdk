using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the type of a category.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogCategoryType>))]
public sealed record CatalogCategoryType : OpenStringEnum<CatalogCategoryType>
{
    private CatalogCategoryType(string value) : base(value)
    {
    }

    /// <summary>
    /// The regular category.
    /// </summary>
    public static readonly CatalogCategoryType RegularCategory = new("REGULAR_CATEGORY");

    /// <summary>
    /// The menu category.
    /// </summary>
    public static readonly CatalogCategoryType MenuCategory = new("MENU_CATEGORY");

    /// <summary>
    /// Kitchen categories are used by KDS (Kitchen Display System) to route items to specific clients
    /// </summary>
    public static readonly CatalogCategoryType KitchenCategory = new("KITCHEN_CATEGORY");

    public TResult Match<TResult>(Func<TResult> onRegularCategory,
        Func<TResult> onMenuCategory,
        Func<TResult> onKitchenCategory,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == RegularCategory => onRegularCategory(),
            _ when this == MenuCategory => onMenuCategory(),
            _ when this == KitchenCategory => onKitchenCategory(),
            _ => otherwise(Value)
        };

    public void Match(Action onRegularCategory,
        Action onMenuCategory,
        Action onKitchenCategory,
        Action<string> otherwise)
    {
        if (this == RegularCategory) onRegularCategory();
        else if (this == MenuCategory) onMenuCategory();
        else if (this == KitchenCategory) onKitchenCategory();
        else otherwise(Value);
    }
}

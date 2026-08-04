using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the type of a category.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogCategoryType>))]
public sealed record CatalogCategoryType : StringEnum<CatalogCategoryType>
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

    public static CatalogCategoryType FromValue(string value) => FromValueCore(value);
}

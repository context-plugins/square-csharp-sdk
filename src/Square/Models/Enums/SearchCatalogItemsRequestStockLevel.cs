using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Defines supported stock levels of the item inventory.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SearchCatalogItemsRequestStockLevel>))]
public sealed record SearchCatalogItemsRequestStockLevel : OpenStringEnum<SearchCatalogItemsRequestStockLevel>
{
    private SearchCatalogItemsRequestStockLevel(string value) : base(value)
    {
    }

    /// <summary>
    /// The item inventory is empty.
    /// </summary>
    public static readonly SearchCatalogItemsRequestStockLevel Out = new("OUT");

    /// <summary>
    /// The item inventory is low.
    /// </summary>
    public static readonly SearchCatalogItemsRequestStockLevel Low = new("LOW");

    public TResult Match<TResult>(Func<TResult> onOut, Func<TResult> onLow, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Out => onOut(),
            _ when this == Low => onLow(),
            _ => otherwise(Value)
        };

    public void Match(Action onOut, Action onLow, Action<string> otherwise)
    {
        if (this == Out) onOut();
        else if (this == Low) onLow();
        else otherwise(Value);
    }
}

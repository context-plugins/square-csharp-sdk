using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates whether Square should alert the merchant when the inventory quantity of a CatalogItemVariation is low.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InventoryAlertType>))]
public sealed record InventoryAlertType : OpenStringEnum<InventoryAlertType>
{
    private InventoryAlertType(string value) : base(value)
    {
    }

    /// <summary>
    /// The variation does not display an alert.
    /// </summary>
    public static readonly InventoryAlertType None = new("NONE");

    /// <summary>
    /// The variation generates an alert when its quantity is low.
    /// </summary>
    public static readonly InventoryAlertType LowQuantity = new("LOW_QUANTITY");

    public TResult Match<TResult>(Func<TResult> onNone, Func<TResult> onLowQuantity, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == None => onNone(),
            _ when this == LowQuantity => onLowQuantity(),
            _ => otherwise(Value)
        };

    public void Match(Action onNone, Action onLowQuantity, Action<string> otherwise)
    {
        if (this == None) onNone();
        else if (this == LowQuantity) onLowQuantity();
        else otherwise(Value);
    }
}

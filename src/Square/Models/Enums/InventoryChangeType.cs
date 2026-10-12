using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates how the inventory change was applied to a tracked product quantity.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InventoryChangeType>))]
public sealed record InventoryChangeType : OpenStringEnum<InventoryChangeType>
{
    private InventoryChangeType(string value) : base(value)
    {
    }

    /// <summary>
    /// The change occurred as part of a physical count update.
    /// </summary>
    public static readonly InventoryChangeType PhysicalCount = new("PHYSICAL_COUNT");

    /// <summary>
    /// The change occurred as part of the normal lifecycle of goods
    /// (e.g., as an inventory adjustment).
    /// </summary>
    public static readonly InventoryChangeType Adjustment = new("ADJUSTMENT");

    public TResult Match<TResult>(Func<TResult> onPhysicalCount,
        Func<TResult> onAdjustment,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PhysicalCount => onPhysicalCount(),
            _ when this == Adjustment => onAdjustment(),
            _ => otherwise(Value)
        };

    public void Match(Action onPhysicalCount, Action onAdjustment, Action<string> otherwise)
    {
        if (this == PhysicalCount) onPhysicalCount();
        else if (this == Adjustment) onAdjustment();
        else otherwise(Value);
    }
}

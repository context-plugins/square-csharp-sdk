using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<InventoryAdjustmentReasonDirection>))]
public sealed record InventoryAdjustmentReasonDirection : OpenStringEnum<InventoryAdjustmentReasonDirection>
{
    private InventoryAdjustmentReasonDirection(string value) : base(value)
    {
    }

    public static readonly InventoryAdjustmentReasonDirection Increase = new("INCREASE");

    public static readonly InventoryAdjustmentReasonDirection Decrease = new("DECREASE");

    public TResult Match<TResult>(Func<TResult> onIncrease,
        Func<TResult> onDecrease,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Increase => onIncrease(),
            _ when this == Decrease => onDecrease(),
            _ => otherwise(Value)
        };

    public void Match(Action onIncrease, Action onDecrease, Action<string> otherwise)
    {
        if (this == Increase) onIncrease();
        else if (this == Decrease) onDecrease();
        else otherwise(Value);
    }
}

using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<InventoryAdjustmentReasonDirection>))]
public sealed record InventoryAdjustmentReasonDirection : StringEnum<InventoryAdjustmentReasonDirection>
{
    private InventoryAdjustmentReasonDirection(string value) : base(value)
    {
    }

    public static readonly InventoryAdjustmentReasonDirection Increase = new("INCREASE");

    public static readonly InventoryAdjustmentReasonDirection Decrease = new("DECREASE");

    public static InventoryAdjustmentReasonDirection FromValue(string value) => FromValueCore(value);
}

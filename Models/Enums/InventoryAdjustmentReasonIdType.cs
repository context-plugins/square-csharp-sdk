using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The type of inventory adjustment reason.
/// <para>
/// Custom reasons use <c>CUSTOM</c> and include a <c>custom_reason_id</c>. Standard
/// seller-selectable reasons use <c>RECEIVED</c>, <c>DAMAGED</c>, <c>THEFT</c>, <c>LOST</c>,
/// <c>RETURNED</c>, <c>SPOILAGE_WASTE</c>, <c>SAMPLES_PROMOTIONAL</c>, <c>INTERNAL_USE</c>,
/// <c>VENDOR_RETURN</c>, or <c>PRODUCTION_WASTE</c>.
/// </para>
/// <para>
/// The writable standard reasons with direction <c>INCREASE</c> are <c>RECEIVED</c>
/// and <c>RETURNED</c>. The writable standard reasons with direction <c>DECREASE</c>
/// are <c>DAMAGED</c>, <c>THEFT</c>, <c>LOST</c>, <c>SPOILAGE_WASTE</c>,
/// <c>SAMPLES_PROMOTIONAL</c>, <c>INTERNAL_USE</c>, <c>VENDOR_RETURN</c>, and
/// <c>PRODUCTION_WASTE</c>.
/// </para>
/// <para>
/// The <c>SALE</c>, <c>RECOUNT</c>, <c>TRANSFER</c>, <c>IN_TRANSIT</c>, and <c>CANCELED_SALE</c>
/// values identify system-generated inventory events. These values can be
/// returned by Square, but cannot be used when writing inventory adjustments.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InventoryAdjustmentReasonIdType>))]
public sealed record InventoryAdjustmentReasonIdType : StringEnum<InventoryAdjustmentReasonIdType>
{
    private InventoryAdjustmentReasonIdType(string value) : base(value)
    {
    }

    public static readonly InventoryAdjustmentReasonIdType Received = new("RECEIVED");

    public static readonly InventoryAdjustmentReasonIdType Damaged = new("DAMAGED");

    public static readonly InventoryAdjustmentReasonIdType Theft = new("THEFT");

    public static readonly InventoryAdjustmentReasonIdType Lost = new("LOST");

    public static readonly InventoryAdjustmentReasonIdType Returned = new("RETURNED");

    public static readonly InventoryAdjustmentReasonIdType SpoilageWaste = new("SPOILAGE_WASTE");

    public static readonly InventoryAdjustmentReasonIdType SamplesPromotional = new("SAMPLES_PROMOTIONAL");

    public static readonly InventoryAdjustmentReasonIdType InternalUse = new("INTERNAL_USE");

    public static readonly InventoryAdjustmentReasonIdType VendorReturn = new("VENDOR_RETURN");

    public static readonly InventoryAdjustmentReasonIdType ProductionWaste = new("PRODUCTION_WASTE");

    public static readonly InventoryAdjustmentReasonIdType Sale = new("SALE");

    public static readonly InventoryAdjustmentReasonIdType Recount = new("RECOUNT");

    public static readonly InventoryAdjustmentReasonIdType Transfer = new("TRANSFER");

    public static readonly InventoryAdjustmentReasonIdType InTransit = new("IN_TRANSIT");

    public static readonly InventoryAdjustmentReasonIdType CanceledSale = new("CANCELED_SALE");

    public static readonly InventoryAdjustmentReasonIdType Custom = new("CUSTOM");

    public static InventoryAdjustmentReasonIdType FromValue(string value) => FromValueCore(value);
}

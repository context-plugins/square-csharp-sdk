using System;
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
public sealed record InventoryAdjustmentReasonIdType : OpenStringEnum<InventoryAdjustmentReasonIdType>
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

    public TResult Match<TResult>(Func<TResult> onReceived,
        Func<TResult> onDamaged,
        Func<TResult> onTheft,
        Func<TResult> onLost,
        Func<TResult> onReturned,
        Func<TResult> onSpoilageWaste,
        Func<TResult> onSamplesPromotional,
        Func<TResult> onInternalUse,
        Func<TResult> onVendorReturn,
        Func<TResult> onProductionWaste,
        Func<TResult> onSale,
        Func<TResult> onRecount,
        Func<TResult> onTransfer,
        Func<TResult> onInTransit,
        Func<TResult> onCanceledSale,
        Func<TResult> onCustom,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Received => onReceived(),
            _ when this == Damaged => onDamaged(),
            _ when this == Theft => onTheft(),
            _ when this == Lost => onLost(),
            _ when this == Returned => onReturned(),
            _ when this == SpoilageWaste => onSpoilageWaste(),
            _ when this == SamplesPromotional => onSamplesPromotional(),
            _ when this == InternalUse => onInternalUse(),
            _ when this == VendorReturn => onVendorReturn(),
            _ when this == ProductionWaste => onProductionWaste(),
            _ when this == Sale => onSale(),
            _ when this == Recount => onRecount(),
            _ when this == Transfer => onTransfer(),
            _ when this == InTransit => onInTransit(),
            _ when this == CanceledSale => onCanceledSale(),
            _ when this == Custom => onCustom(),
            _ => otherwise(Value)
        };

    public void Match(Action onReceived,
        Action onDamaged,
        Action onTheft,
        Action onLost,
        Action onReturned,
        Action onSpoilageWaste,
        Action onSamplesPromotional,
        Action onInternalUse,
        Action onVendorReturn,
        Action onProductionWaste,
        Action onSale,
        Action onRecount,
        Action onTransfer,
        Action onInTransit,
        Action onCanceledSale,
        Action onCustom,
        Action<string> otherwise)
    {
        if (this == Received) onReceived();
        else if (this == Damaged) onDamaged();
        else if (this == Theft) onTheft();
        else if (this == Lost) onLost();
        else if (this == Returned) onReturned();
        else if (this == SpoilageWaste) onSpoilageWaste();
        else if (this == SamplesPromotional) onSamplesPromotional();
        else if (this == InternalUse) onInternalUse();
        else if (this == VendorReturn) onVendorReturn();
        else if (this == ProductionWaste) onProductionWaste();
        else if (this == Sale) onSale();
        else if (this == Recount) onRecount();
        else if (this == Transfer) onTransfer();
        else if (this == InTransit) onInTransit();
        else if (this == CanceledSale) onCanceledSale();
        else if (this == Custom) onCustom();
        else otherwise(Value);
    }
}

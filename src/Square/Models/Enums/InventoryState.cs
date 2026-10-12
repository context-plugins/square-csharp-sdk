using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the state of a tracked item quantity in the lifecycle of goods.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InventoryState>))]
public sealed record InventoryState : OpenStringEnum<InventoryState>
{
    private InventoryState(string value) : base(value)
    {
    }

    /// <summary>
    /// The related quantity of items are in a custom state. <b>READ-ONLY</b>:
    /// the Inventory API cannot move quantities to or from this state.
    /// </summary>
    public static readonly InventoryState Custom = new("CUSTOM");

    /// <summary>
    /// The related quantity of items are on hand and available for sale.
    /// </summary>
    public static readonly InventoryState InStock = new("IN_STOCK");

    /// <summary>
    /// The related quantity of items were sold as part of an itemized
    /// transaction. Quantities in the <c>SOLD</c> state are no longer tracked.
    /// </summary>
    public static readonly InventoryState Sold = new("SOLD");

    /// <summary>
    /// The related quantity of items were returned through the Square Point
    /// of Sale application, but are not yet available for sale. <b>READ-ONLY</b>:
    /// the Inventory API cannot move quantities to or from this state.
    /// </summary>
    public static readonly InventoryState ReturnedByCustomer = new("RETURNED_BY_CUSTOMER");

    /// <summary>
    /// The related quantity of items are on hand, but not currently
    /// available for sale. <b>READ-ONLY</b>: the Inventory API cannot move
    /// quantities to or from this state.
    /// </summary>
    public static readonly InventoryState ReservedForSale = new("RESERVED_FOR_SALE");

    /// <summary>
    /// The related quantity of items were sold online. <b>READ-ONLY</b>: the
    /// Inventory API cannot move quantities to or from this state.
    /// </summary>
    public static readonly InventoryState SoldOnline = new("SOLD_ONLINE");

    /// <summary>
    /// The related quantity of items were ordered from a vendor but not yet
    /// received. <b>READ-ONLY</b>: the Inventory API cannot move quantities to or
    /// from this state.
    /// </summary>
    public static readonly InventoryState OrderedFromVendor = new("ORDERED_FROM_VENDOR");

    /// <summary>
    /// The related quantity of items were received from a vendor but are
    /// not yet available for sale. <b>READ-ONLY</b>: the Inventory API cannot move
    /// quantities to or from this state.
    /// </summary>
    public static readonly InventoryState ReceivedFromVendor = new("RECEIVED_FROM_VENDOR");

    /// <summary>
    /// Replaced by <c>IN_TRANSIT</c> to represent quantities
    /// of items that are in transit between locations.
    /// </summary>
    public static readonly InventoryState InTransitTo = new("IN_TRANSIT_TO");

    /// <summary>
    /// A placeholder indicating that the related quantity of items are not
    /// currently tracked in Square. Transferring quantities from the <c>NONE</c> state
    /// to a tracked state (e.g., <c>IN_STOCK</c>) introduces stock into the system.
    /// </summary>
    public static readonly InventoryState None = new("NONE");

    /// <summary>
    /// The related quantity of items are lost or damaged and cannot be
    /// sold.
    /// </summary>
    public static readonly InventoryState Waste = new("WASTE");

    /// <summary>
    /// The related quantity of items were returned but not linked to a
    /// previous transaction. Unlinked returns are not tracked in Square.
    /// Transferring a quantity from <c>UNLINKED_RETURN</c> to a tracked state (e.g.,
    /// <c>IN_STOCK</c>) introduces new stock into the system.
    /// </summary>
    public static readonly InventoryState UnlinkedReturn = new("UNLINKED_RETURN");

    /// <summary>
    /// The related quantity of items that are part of a composition consisting one or more components.
    /// </summary>
    public static readonly InventoryState Composed = new("COMPOSED");

    /// <summary>
    /// The related quantity of items that are part of a component.
    /// </summary>
    public static readonly InventoryState Decomposed = new("DECOMPOSED");

    /// <summary>
    /// This state is not supported by this version of the Square API. We recommend that you upgrade the client to use the appropriate version of the Square API supporting this state.
    /// </summary>
    public static readonly InventoryState SupportedByNewerVersion = new("SUPPORTED_BY_NEWER_VERSION");

    /// <summary>
    /// The related quantity of items are in transit between locations. <b>READ-ONLY:</b> the Inventory API cannot currently be used to move quantities to or from this inventory state.
    /// </summary>
    public static readonly InventoryState InTransit = new("IN_TRANSIT");

    /// <summary>
    /// The related quantity of items are untracked.
    /// </summary>
    public static readonly InventoryState Untracked = new("UNTRACKED");

    public TResult Match<TResult>(Func<TResult> onCustom,
        Func<TResult> onInStock,
        Func<TResult> onSold,
        Func<TResult> onReturnedByCustomer,
        Func<TResult> onReservedForSale,
        Func<TResult> onSoldOnline,
        Func<TResult> onOrderedFromVendor,
        Func<TResult> onReceivedFromVendor,
        Func<TResult> onInTransitTo,
        Func<TResult> onNone,
        Func<TResult> onWaste,
        Func<TResult> onUnlinkedReturn,
        Func<TResult> onComposed,
        Func<TResult> onDecomposed,
        Func<TResult> onSupportedByNewerVersion,
        Func<TResult> onInTransit,
        Func<TResult> onUntracked,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Custom => onCustom(),
            _ when this == InStock => onInStock(),
            _ when this == Sold => onSold(),
            _ when this == ReturnedByCustomer => onReturnedByCustomer(),
            _ when this == ReservedForSale => onReservedForSale(),
            _ when this == SoldOnline => onSoldOnline(),
            _ when this == OrderedFromVendor => onOrderedFromVendor(),
            _ when this == ReceivedFromVendor => onReceivedFromVendor(),
            _ when this == InTransitTo => onInTransitTo(),
            _ when this == None => onNone(),
            _ when this == Waste => onWaste(),
            _ when this == UnlinkedReturn => onUnlinkedReturn(),
            _ when this == Composed => onComposed(),
            _ when this == Decomposed => onDecomposed(),
            _ when this == SupportedByNewerVersion => onSupportedByNewerVersion(),
            _ when this == InTransit => onInTransit(),
            _ when this == Untracked => onUntracked(),
            _ => otherwise(Value)
        };

    public void Match(Action onCustom,
        Action onInStock,
        Action onSold,
        Action onReturnedByCustomer,
        Action onReservedForSale,
        Action onSoldOnline,
        Action onOrderedFromVendor,
        Action onReceivedFromVendor,
        Action onInTransitTo,
        Action onNone,
        Action onWaste,
        Action onUnlinkedReturn,
        Action onComposed,
        Action onDecomposed,
        Action onSupportedByNewerVersion,
        Action onInTransit,
        Action onUntracked,
        Action<string> otherwise)
    {
        if (this == Custom) onCustom();
        else if (this == InStock) onInStock();
        else if (this == Sold) onSold();
        else if (this == ReturnedByCustomer) onReturnedByCustomer();
        else if (this == ReservedForSale) onReservedForSale();
        else if (this == SoldOnline) onSoldOnline();
        else if (this == OrderedFromVendor) onOrderedFromVendor();
        else if (this == ReceivedFromVendor) onReceivedFromVendor();
        else if (this == InTransitTo) onInTransitTo();
        else if (this == None) onNone();
        else if (this == Waste) onWaste();
        else if (this == UnlinkedReturn) onUnlinkedReturn();
        else if (this == Composed) onComposed();
        else if (this == Decomposed) onDecomposed();
        else if (this == SupportedByNewerVersion) onSupportedByNewerVersion();
        else if (this == InTransit) onInTransit();
        else if (this == Untracked) onUntracked();
        else otherwise(Value);
    }
}

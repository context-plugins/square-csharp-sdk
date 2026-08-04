using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Status values for transfer orders. Represents the current state of a
/// <see href="entity:TransferOrder">TransferOrder</see> in its lifecycle from creation to completion.
/// Each status determines what actions are available and how inventory is affected.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferOrderStatus>))]
public sealed record TransferOrderStatus : StringEnum<TransferOrderStatus>
{
    private TransferOrderStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// Initial status when transfer order is created via <see href="api-endpoint:TransferOrders-CreateTransferOrder">CreateTransferOrder</see>.
    /// Order can be modified or deleted. No inventory impact at this stage.
    /// </summary>
    public static readonly TransferOrderStatus Draft = new("DRAFT");

    /// <summary>
    /// Transfer order has been started via <see href="api-endpoint:TransferOrders-StartTransferOrder">StartTransferOrder</see>.
    /// Order can no longer be deleted. <see href="entity:CatalogItemVariation">CatalogItemVariation</see>s are decremented
    /// from source <see href="entity:Location">Location</see> and marked as in-transit to destination.
    /// </summary>
    public static readonly TransferOrderStatus Started = new("STARTED");

    /// <summary>
    /// Some items have been received via <see href="api-endpoint:TransferOrders-ReceiveTransferOrder">ReceiveTransferOrder</see>
    /// but there are still pending quantities. Additional receipts are allowed.
    /// <see href="entity:CatalogItemVariation">CatalogItemVariation</see>s are incrementally added to destination
    /// <see href="entity:Location">Location</see> inventory as they are received.
    /// </summary>
    public static readonly TransferOrderStatus PartiallyReceived = new("PARTIALLY_RECEIVED");

    /// <summary>
    /// All items have been received or canceled, no pending quantities remain.
    /// Only metadata modifications are allowed. Final inventory adjustments are complete
    /// at both source and destination <see href="entity:Location">Location</see>s.
    /// </summary>
    public static readonly TransferOrderStatus Completed = new("COMPLETED");

    /// <summary>
    /// Transfer order was canceled via <see href="api-endpoint:TransferOrders-CancelTransferOrder">CancelTransferOrder</see>.
    /// Any pending quantities are no longer receivable and are returned to source <see href="entity:Location">Location</see>.
    /// Only metadata modifications are allowed.
    /// </summary>
    public static readonly TransferOrderStatus Canceled = new("CANCELED");

    public static TransferOrderStatus FromValue(string value) => FromValueCore(value);
}

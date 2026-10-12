using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a line item in a transfer order. Each line item tracks a specific
/// <see href="entity:CatalogItemVariation">CatalogItemVariation</see> being transferred, including ordered quantities
/// and receipt status.
/// </summary>
public record TransferOrderLine
{
    /// <summary>
    /// Unique system-generated identifier for the line item. Provide when updating/removing a line via <see href="api-endpoint:TransferOrders-UpdateTransferOrder">UpdateTransferOrder</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    public string? Uid { get; init; }

    /// <summary>
    /// The required identifier of the <see href="entity:CatalogItemVariation">CatalogItemVariation</see> being transferred. Must reference
    /// a valid catalog item variation that exists in the <see href="api:Catalog">Catalog</see>.
    /// </summary>
    [JsonPropertyName("item_variation_id")]
    [StringLength(64, MinimumLength = 1)]
    [RegularExpression("^[a-zA-Z0-9_:\\-]+$")]
    public required string ItemVariationId { get; init; }

    /// <summary>
    /// Total quantity ordered, formatted as a decimal string (e.g. "10 or 10.0000"). Required to be a positive number.
    /// <para>
    /// To remove a line item, set <c>remove</c> to <c>true</c> in <see href="api-endpoint:TransferOrders-UpdateTransferOrder">UpdateTransferOrder</see>.
    /// </para>
    /// </summary>
    [JsonPropertyName("quantity_ordered")]
    [MinLength(1)]
    [RegularExpression("^\\d*\\.?\\d*$")]
    public required string QuantityOrdered { get; init; }

    /// <summary>
    /// Calculated quantity of this line item's yet to be received stock. This is the difference between the total quantity ordered and the sum of quantities received, canceled, and damaged.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity_pending")]
    public string? QuantityPending { get; init; }

    /// <summary>
    /// Quantity received at destination. These items are added to the destination
    /// <see href="entity:Location">Location</see>'s inventory with <see href="entity:InventoryState">InventoryState</see> of IN_STOCK.
    /// <para>
    /// This field cannot be updated directly in Create/Update operations, instead use <see href="api-endpoint:TransferOrders-ReceiveTransferOrder">ReceiveTransferOrder</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity_received")]
    public string? QuantityReceived { get; init; }

    /// <summary>
    /// Quantity received in damaged condition. These items are added to the destination
    /// <see href="entity:Location">Location</see>'s inventory with <see href="entity:InventoryState">InventoryState</see> of WASTE.
    /// <para>
    /// This field cannot be updated directly in Create/Update operations, instead use <see href="api-endpoint:TransferOrders-ReceiveTransferOrder">ReceiveTransferOrder</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity_damaged")]
    public string? QuantityDamaged { get; init; }

    /// <summary>
    /// Quantity that was canceled. These items will be immediately added to inventory in the source location.
    /// <para>
    /// This field cannot be updated directly in Create/Update operations, instead use <see href="api-endpoint:TransferOrders-ReceiveTransferOrder">ReceiveTransferOrder</see> or <see href="api-endpoint:TransferOrders-CancelTransferOrder">CancelTransferOrder</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity_canceled")]
    public string? QuantityCanceled { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

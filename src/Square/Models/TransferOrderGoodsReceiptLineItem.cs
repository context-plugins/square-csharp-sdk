using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// A simplified line item for goods receipts in transfer orders
/// </summary>
public record TransferOrderGoodsReceiptLineItem
{
    /// <summary>
    /// The unique identifier of the Transfer Order line being received
    /// </summary>
    [JsonPropertyName("transfer_order_line_uid")]
    [MaxLength(64)]
    public required string TransferOrderLineUid { get; init; }

    /// <summary>
    /// The quantity received for this line item as a decimal string (e.g. "10.5").
    /// These items will be added to the destination <see href="entity:Location">Location</see>'s inventory with <see href="entity:InventoryState">InventoryState</see> of IN_STOCK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity_received")]
    [StringLength(16, MinimumLength = 1)]
    [RegularExpression("^(0|[1-9]\\d*)(\\.\\d{1,4})?$")]
    public string? QuantityReceived { get; init; }

    /// <summary>
    /// The quantity that was damaged during shipping/handling as a decimal string (e.g. "1.5").
    /// These items will be added to the destination <see href="entity:Location">Location</see>'s inventory with <see href="entity:InventoryState">InventoryState</see> of WASTE.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity_damaged")]
    [StringLength(16, MinimumLength = 1)]
    [RegularExpression("^(0|[1-9]\\d*)(\\.\\d{1,4})?$")]
    public string? QuantityDamaged { get; init; }

    /// <summary>
    /// The quantity that was canceled during shipping/handling as a decimal string (e.g. "1.5"). These will be immediately added to inventory in the source location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity_canceled")]
    [StringLength(16, MinimumLength = 1)]
    [RegularExpression("^(0|[1-9]\\d*)(\\.\\d{1,4})?$")]
    public string? QuantityCanceled { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Identifies a standard or custom inventory adjustment reason.
/// </summary>
public record InventoryAdjustmentReasonId
{
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
    [JsonPropertyName("type")]
    public required InventoryAdjustmentReasonIdType Type { get; init; }

    /// <summary>
    /// The Square-generated ID of the custom adjustment reason. This field
    /// is only set when <c>type</c> is <c>CUSTOM</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_reason_id")]
    [MaxLength(100)]
    public string? CustomReasonId { get; init; }
}

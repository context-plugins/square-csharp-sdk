using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an input to a call to <see href="api-endpoint:Inventory-UpdateInventoryAdjustmentReason">UpdateInventoryAdjustmentReason</see>.
/// </summary>
public record UpdateInventoryAdjustmentReasonRequest
{
    /// <summary>
    /// Identifies a standard or custom inventory adjustment reason.
    /// </summary>
    [JsonPropertyName("reason_id")]
    public required InventoryAdjustmentReasonId ReasonId { get; init; }

    /// <summary>
    /// Represents an inventory adjustment reason.
    /// </summary>
    [JsonPropertyName("adjustment_reason")]
    public required InventoryAdjustmentReason AdjustmentReason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

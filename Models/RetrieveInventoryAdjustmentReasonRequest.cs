using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents an input to a call to <see href="api-endpoint:Inventory-RetrieveInventoryAdjustmentReason">RetrieveInventoryAdjustmentReason</see>.
/// </summary>
public record RetrieveInventoryAdjustmentReasonRequest
{
    /// <summary>
    /// Identifies a standard or custom inventory adjustment reason.
    /// </summary>
    [JsonPropertyName("reason_id")]
    public required InventoryAdjustmentReasonId ReasonId { get; init; }
}

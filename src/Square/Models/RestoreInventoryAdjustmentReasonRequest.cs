using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an input to a call to <see href="api-endpoint:Inventory-RestoreInventoryAdjustmentReason">RestoreInventoryAdjustmentReason</see>.
/// </summary>
public record RestoreInventoryAdjustmentReasonRequest
{
    /// <summary>
    /// Identifies a standard or custom inventory adjustment reason.
    /// </summary>
    [JsonPropertyName("reason_id")]
    public required InventoryAdjustmentReasonId ReasonId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

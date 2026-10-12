using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an input to a call to <see href="api-endpoint:Inventory-CreateInventoryAdjustmentReason">CreateInventoryAdjustmentReason</see>.
/// </summary>
public record CreateInventoryAdjustmentReasonRequest
{
    /// <summary>
    /// A client-supplied, universally unique identifier to make this
    /// <see href="api-endpoint:Inventory-CreateInventoryAdjustmentReason">CreateInventoryAdjustmentReason</see>
    /// request idempotent.
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// Represents an inventory adjustment reason.
    /// </summary>
    [JsonPropertyName("adjustment_reason")]
    public required InventoryAdjustmentReason AdjustmentReason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

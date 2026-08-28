using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an input to a call to <see href="api-endpoint:Inventory-DeleteInventoryAdjustmentReason">DeleteInventoryAdjustmentReason</see>.
/// </summary>
public record DeleteInventoryAdjustmentReasonRequest
{
    /// <summary>
    /// Identifies a standard or custom inventory adjustment reason.
    /// </summary>
    [JsonPropertyName("reason_id")]
    public required InventoryAdjustmentReasonId ReasonId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

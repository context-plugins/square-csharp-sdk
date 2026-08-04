using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents an output from a call to <see href="api-endpoint:Inventory-ListInventoryAdjustmentReasons">ListInventoryAdjustmentReasons</see>.
/// </summary>
public record ListInventoryAdjustmentReasonsResponse
{
    /// <summary>
    /// Errors encountered when the request fails.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The standard, system-generated, and custom inventory adjustment
    /// reasons available to the seller.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjustment_reasons")]
    public IReadOnlyList<InventoryAdjustmentReason>? AdjustmentReasons { get; init; }
}

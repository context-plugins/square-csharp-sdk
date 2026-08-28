using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an output from a call to <see href="api-endpoint:Inventory-DeleteInventoryAdjustmentReason">DeleteInventoryAdjustmentReason</see>.
/// </summary>
public record DeleteInventoryAdjustmentReasonResponse
{
    /// <summary>
    /// Errors encountered when the request fails.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents an inventory adjustment reason.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjustment_reason")]
    public InventoryAdjustmentReason? AdjustmentReason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

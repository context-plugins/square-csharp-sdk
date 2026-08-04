using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

public record InventoryCountUpdatedEventObject
{
    /// <summary>
    /// The inventory counts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inventory_counts")]
    public IReadOnlyList<InventoryCount?>? InventoryCounts { get; init; }
}

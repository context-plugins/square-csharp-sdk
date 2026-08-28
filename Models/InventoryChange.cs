using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a single physical count, inventory, adjustment, or transfer
/// that is part of the history of inventory changes for a particular
/// <see href="entity:CatalogObject">CatalogObject</see> instance.
/// </summary>
public record InventoryChange
{
    /// <summary>
    /// Indicates how the inventory change was applied to a tracked product quantity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public InventoryChangeType? Type { get; init; }

    /// <summary>
    /// Represents the quantity of an item variation that is physically present
    /// at a specific location, verified by a seller or a seller's employee. For example,
    /// a physical count might come from an employee counting the item variations on
    /// hand or from syncing with an external system.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("physical_count")]
    public InventoryPhysicalCount? PhysicalCount { get; init; }

    /// <summary>
    /// Represents a change in state or quantity of product inventory at a
    /// particular time and location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjustment")]
    public InventoryAdjustment? Adjustment { get; init; }

    /// <summary>
    /// Represents the unit used to measure a <c>CatalogItemVariation</c> and
    /// specifies the precision for decimal quantities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("measurement_unit")]
    public CatalogMeasurementUnit? MeasurementUnit { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:CatalogMeasurementUnit">CatalogMeasurementUnit</see> object representing the catalog measurement unit associated with the inventory change.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("measurement_unit_id")]
    public string? MeasurementUnitId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

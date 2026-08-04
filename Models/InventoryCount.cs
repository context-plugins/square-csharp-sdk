using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents Square-estimated quantity of items in a particular state at a
/// particular seller location based on the known history of physical counts and
/// inventory adjustments. The absence of an inventory count indicates that the
/// catalog object hasn't interacted with the given inventory state at the given location.
/// </summary>
public record InventoryCount
{
    /// <summary>
    /// The Square-generated ID of the
    /// <see href="entity:CatalogObject">CatalogObject</see> being tracked.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_object_id")]
    [MaxLength(100)]
    public string? CatalogObjectId { get; init; }

    /// <summary>
    /// The <see href="entity:CatalogObjectType">type</see> of the <see href="entity:CatalogObject">CatalogObject</see> being tracked.
    /// <para>
    /// The Inventory API supports setting and reading the <c>"catalog_object_type": "ITEM_VARIATION"</c> field value.
    /// In addition, it can also read the <c>"catalog_object_type": "ITEM"</c> field value that is set by the Square Restaurants app.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_object_type")]
    [MaxLength(14)]
    public string? CatalogObjectType { get; init; }

    /// <summary>
    /// Indicates the state of a tracked item quantity in the lifecycle of goods.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public InventoryState? State { get; init; }

    /// <summary>
    /// The Square-generated ID of the <see href="entity:Location">Location</see> where the related
    /// quantity of items is being tracked.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    [MaxLength(100)]
    public string? LocationId { get; init; }

    /// <summary>
    /// The number of items affected by the estimated count as a decimal string.
    /// Can support up to 5 digits after the decimal point.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity")]
    [MaxLength(26)]
    public string? Quantity { get; init; }

    /// <summary>
    /// An RFC 3339-formatted timestamp that indicates when the most recent physical count or adjustment affecting
    /// the estimated count is received.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("calculated_at")]
    [MaxLength(34)]
    public string? CalculatedAt { get; init; }

    /// <summary>
    /// Whether the inventory count is for composed variation (TRUE) or not (FALSE). If true, the inventory count will not be present in the response of
    /// any of these endpoints: <see href="api-endpoint:Inventory-BatchChangeInventory">BatchChangeInventory</see>,
    /// <see href="api-endpoint:Inventory-BatchRetrieveInventoryChanges">BatchRetrieveInventoryChanges</see>,
    /// <see href="api-endpoint:Inventory-BatchRetrieveInventoryCounts">BatchRetrieveInventoryCounts</see>, and
    /// <see href="api-endpoint:Inventory-RetrieveInventoryChanges">RetrieveInventoryChanges</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_estimated")]
    public bool? IsEstimated { get; init; }
}

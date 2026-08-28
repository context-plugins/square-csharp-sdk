using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Data for creating a new transfer order line item. Each line item specifies a
/// <see href="entity:CatalogItemVariation">CatalogItemVariation</see> and quantity to transfer.
/// </summary>
public record CreateTransferOrderLineData
{
    /// <summary>
    /// ID of the <see href="entity:CatalogItemVariation">CatalogItemVariation</see> to transfer. Must reference a valid
    /// item variation in the <see href="api:Catalog">Catalog</see>. The item variation must be:
    /// - Active and available for sale
    /// - Enabled for inventory tracking
    /// - Available at the source location
    /// </summary>
    [JsonPropertyName("item_variation_id")]
    [StringLength(64, MinimumLength = 1)]
    public required string ItemVariationId { get; init; }

    /// <summary>
    /// Total quantity ordered
    /// </summary>
    [JsonPropertyName("quantity_ordered")]
    [StringLength(16, MinimumLength = 1)]
    [RegularExpression("^(0|[1-9]\\d*)(\\.\\d{1,4})?$")]
    public required string QuantityOrdered { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a line item update in a transfer order
/// </summary>
public record UpdateTransferOrderLineData
{
    /// <summary>
    /// Line item id being updated. Required for updating/removing existing line items, but should not be set for new line items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    [StringLength(64, MinimumLength = 1)]
    public string? Uid { get; init; }

    /// <summary>
    /// Catalog item variation being transferred
    /// <para>
    /// Required for new line items, but otherwise is not updatable.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_variation_id")]
    [StringLength(64, MinimumLength = 1)]
    public string? ItemVariationId { get; init; }

    /// <summary>
    /// Total quantity ordered
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity_ordered")]
    [StringLength(16, MinimumLength = 1)]
    [RegularExpression("^(0|[1-9]\\d*)(\\.\\d{1,4})?$")]
    public string? QuantityOrdered { get; init; }

    /// <summary>
    /// Flag to remove the line item during update. Must include <c>uid</c> in removal request
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("remove")]
    public bool? Remove { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

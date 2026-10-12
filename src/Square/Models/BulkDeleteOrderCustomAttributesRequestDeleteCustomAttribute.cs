using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents one delete within the bulk operation.
/// </summary>
public record BulkDeleteOrderCustomAttributesRequestDeleteCustomAttribute
{
    /// <summary>
    /// The key of the custom attribute to delete.  This key must match the key
    /// of an existing custom attribute definition.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    [MinLength(1)]
    public string? Key { get; init; }

    /// <summary>
    /// The ID of the target <see href="entity:Order">order</see>.
    /// </summary>
    [JsonPropertyName("order_id")]
    [StringLength(255, MinimumLength = 1)]
    public required string OrderId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

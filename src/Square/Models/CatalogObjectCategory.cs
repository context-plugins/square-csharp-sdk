using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// A category that can be assigned to an item or a parent category that can be assigned
/// to another category. For example, a clothing category can be assigned to a t-shirt item or
/// be made as the parent category to the pants category.
/// </summary>
public record CatalogObjectCategory
{
    /// <summary>
    /// The ID of the object's category.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The position of this object within the specified category. When an item is assigned to a category,
    /// the ordinal determines the item's position relative to other items in the same category. When used for a
    /// parent category reference, the ordinal determines the category's position among its sibling categories.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ordinal")]
    public long? Ordinal { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

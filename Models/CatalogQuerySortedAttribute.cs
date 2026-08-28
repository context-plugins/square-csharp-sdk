using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// The query expression to specify the key to sort search results.
/// </summary>
public record CatalogQuerySortedAttribute
{
    /// <summary>
    /// The attribute whose value is used as the sort key.
    /// </summary>
    [JsonPropertyName("attribute_name")]
    [MinLength(1)]
    public required string AttributeName { get; init; }

    /// <summary>
    /// The first attribute value to be returned by the query. Ascending sorts will return only
    /// objects with this value or greater, while descending sorts will return only objects with this value
    /// or less. If unset, start at the beginning (for ascending sorts) or end (for descending sorts).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("initial_attribute_value")]
    public string? InitialAttributeValue { get; init; }

    /// <summary>
    /// The order (e.g., chronological or alphabetical) in which results from a request are returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort_order")]
    public SortOrder? SortOrder { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

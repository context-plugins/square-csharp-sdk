using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// The query filter to return the search result whose named attribute values are prefixed by the specified attribute value.
/// </summary>
public record CatalogQueryPrefix
{
    /// <summary>
    /// The name of the attribute to be searched.
    /// </summary>
    [JsonPropertyName("attribute_name")]
    [MinLength(1)]
    public required string AttributeName { get; init; }

    /// <summary>
    /// The desired prefix of the search attribute value.
    /// </summary>
    [JsonPropertyName("attribute_prefix")]
    [MinLength(1)]
    public required string AttributePrefix { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

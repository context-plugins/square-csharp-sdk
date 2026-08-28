using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Criteria to sort events by.
/// </summary>
public record SearchEventsSort
{
    /// <summary>
    /// Specifies the sort key for events returned from a search.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field")]
    public SearchEventsSortField? Field { get; init; }

    /// <summary>
    /// The order (e.g., chronological or alphabetical) in which results from a request are returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public SortOrder? Order { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

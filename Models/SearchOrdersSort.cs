using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Sorting criteria for a <c>SearchOrders</c> request. Results can only be sorted
/// by a timestamp field.
/// </summary>
public record SearchOrdersSort
{
    /// <summary>
    /// Specifies which timestamp to use to sort <c>SearchOrder</c> results.
    /// </summary>
    [JsonPropertyName("sort_field")]
    public required SearchOrdersSortField SortField { get; init; }

    /// <summary>
    /// The order (e.g., chronological or alphabetical) in which results from a request are returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort_order")]
    public SortOrder? SortOrder { get; init; }
}

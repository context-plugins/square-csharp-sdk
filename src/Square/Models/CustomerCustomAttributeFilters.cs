using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// The custom attribute filters in a set of <see href="entity:CustomerFilter">customer filters</see> used in a search query. Use this filter
/// to search based on <see href="entity:CustomAttribute">custom attributes</see> that are assigned to customer profiles. For more information, see
/// <see href="https://developer.squareup.com/docs/customers-api/use-the-api/search-customers#search-by-custom-attribute">Search by custom attribute</see>.
/// </summary>
public record CustomerCustomAttributeFilters
{
    /// <summary>
    /// The custom attribute filters. Each filter must specify <c>key</c> and include the <c>filter</c> field with a type-specific filter,
    /// the <c>updated_at</c> field, or both. The provided keys must be unique within the list of custom attribute filters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filters")]
    public IReadOnlyList<CustomerCustomAttributeFilter>? Filters { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

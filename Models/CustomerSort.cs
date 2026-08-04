using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents the sorting criteria in a <see href="entity:CustomerQuery">search query</see> that defines how to sort
/// customer profiles returned in <see href="api-endpoint:Customers-SearchCustomers">SearchCustomers</see> results.
/// </summary>
public record CustomerSort
{
    /// <summary>
    /// Specifies customer attributes as the sort key to customer profiles returned from a search.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field")]
    public CustomerSortField? Field { get; init; }

    /// <summary>
    /// The order (e.g., chronological or alphabetical) in which results from a request are returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public SortOrder? Order { get; init; }
}

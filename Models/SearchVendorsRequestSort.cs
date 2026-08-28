using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Defines a sorter used to sort results from <see href="api-endpoint:Vendors-SearchVendors">SearchVendors</see>.
/// </summary>
public record SearchVendorsRequestSort
{
    /// <summary>
    /// The field to sort the returned <see href="entity:Vendor">Vendor</see> objects by.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field")]
    public SearchVendorsRequestSortField? Field { get; init; }

    /// <summary>
    /// The order (e.g., chronological or alphabetical) in which results from a request are returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public SortOrder? Order { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

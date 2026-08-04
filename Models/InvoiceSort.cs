using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Identifies the sort field and sort order.
/// </summary>
public record InvoiceSort
{
    /// <summary>
    /// The field to use for sorting.
    /// </summary>
    [JsonPropertyName("field")]
    public string Field { get; } = "INVOICE_SORT_DATE";

    /// <summary>
    /// The order (e.g., chronological or alphabetical) in which results from a request are returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public SortOrder? Order { get; init; }
}

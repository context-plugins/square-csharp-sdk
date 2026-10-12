using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Describes query criteria for searching invoices.
/// </summary>
public record InvoiceQuery
{
    /// <summary>
    /// Describes query filters to apply.
    /// </summary>
    [JsonPropertyName("filter")]
    public required InvoiceFilter Filter { get; init; }

    /// <summary>
    /// Identifies the sort field and sort order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort")]
    public InvoiceSort? Sort { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

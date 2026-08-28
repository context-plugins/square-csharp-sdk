using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Describes a <c>SearchInvoices</c> request.
/// </summary>
public record SearchInvoicesRequest
{
    /// <summary>
    /// Describes query criteria for searching invoices.
    /// </summary>
    [JsonPropertyName("query")]
    public required InvoiceQuery Query { get; init; }

    /// <summary>
    /// The maximum number of invoices to return (200 is the maximum <c>limit</c>).
    /// If not provided, the server uses a default limit of 100 invoices.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    public int? Limit { get; init; }

    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this cursor to retrieve the next set of results for your original query.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

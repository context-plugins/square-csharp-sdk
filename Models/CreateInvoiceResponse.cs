using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// The response returned by the <c>CreateInvoice</c> request.
/// </summary>
public record CreateInvoiceResponse
{
    /// <summary>
    /// Stores information about an invoice. You use the Invoices API to create and manage
    /// invoices. For more information, see <see href="https://developer.squareup.com/docs/invoices-api/overview">Invoices API Overview</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoice")]
    public Invoice? Invoice { get; init; }

    /// <summary>
    /// Information about errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

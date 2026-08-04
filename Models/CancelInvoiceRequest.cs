using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Describes a <c>CancelInvoice</c> request.
/// </summary>
public record CancelInvoiceRequest
{
    /// <summary>
    /// The version of the <see href="entity:Invoice">invoice</see> to cancel.
    /// If you do not know the version, you can call
    /// <see href="api-endpoint:Invoices-GetInvoice">GetInvoice</see> or <see href="api-endpoint:Invoices-ListInvoices">ListInvoices</see>.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; init; }
}

using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents the tax IDs for an invoice recipient. The country of the seller account determines
/// whether the corresponding <c>tax_ids</c> field is available for the customer. For more information,
/// see <see href="https://developer.squareup.com/docs/invoices-api/overview#recipient-tax-ids">Invoice recipient tax IDs</see>.
/// </summary>
public record InvoiceRecipientTaxIds
{
    /// <summary>
    /// The EU VAT identification number for the invoice recipient. For example, <c>IE3426675K</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eu_vat")]
    public string? EuVat { get; init; }
}

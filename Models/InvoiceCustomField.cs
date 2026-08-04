using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// An additional seller-defined and customer-facing field to include on the invoice. For more information,
/// see <see href="https://developer.squareup.com/docs/invoices-api/overview#custom-fields">Custom fields</see>.
/// <para>
/// Adding custom fields to an invoice requires an
/// <see href="https://developer.squareup.com/docs/invoices-api/overview#invoices-plus-subscription">Invoices Plus subscription</see>.
/// </para>
/// </summary>
public record InvoiceCustomField
{
    /// <summary>
    /// The label or title of the custom field. This field is required for a custom field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("label")]
    [MaxLength(30)]
    public string? Label { get; init; }

    /// <summary>
    /// The text of the custom field. If omitted, only the label is rendered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    [MaxLength(2000)]
    public string? Value { get; init; }

    /// <summary>
    /// Indicates where to render a custom field on the Square-hosted invoice page and in emailed or PDF
    /// copies of the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("placement")]
    public InvoiceCustomFieldPlacement? Placement { get; init; }
}

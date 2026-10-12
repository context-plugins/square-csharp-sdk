using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Describes a <c>UpdateInvoice</c> request.
/// </summary>
public record UpdateInvoiceRequest
{
    /// <summary>
    /// Stores information about an invoice. You use the Invoices API to create and manage
    /// invoices. For more information, see <see href="https://developer.squareup.com/docs/invoices-api/overview">Invoices API Overview</see>.
    /// </summary>
    [JsonPropertyName("invoice")]
    public required Invoice Invoice { get; init; }

    /// <summary>
    /// A unique string that identifies the <c>UpdateInvoice</c> request. If you do not
    /// provide <c>idempotency_key</c> (or provide an empty string as the value), the endpoint
    /// treats each request as independent.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">Idempotency</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [MaxLength(128)]
    public string? IdempotencyKey { get; init; }

    /// <summary>
    /// The list of fields to clear. Although this field is currently supported, we
    /// recommend using null values or the <c>remove</c> field when possible. For examples, see
    /// <see href="https://developer.squareup.com/docs/invoices-api/update-invoices">Update an Invoice</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fields_to_clear")]
    public IReadOnlyList<string>? FieldsToClear { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:Invoices-CreateInvoiceAttachment">CreateInvoiceAttachment</see> response.
/// </summary>
public record CreateInvoiceAttachmentResponse
{
    /// <summary>
    /// Represents a file attached to an <see href="entity:Invoice">invoice</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attachment")]
    public InvoiceAttachment? Attachment { get; init; }

    /// <summary>
    /// Information about errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}

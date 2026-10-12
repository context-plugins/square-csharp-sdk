using Square.Core.Models;
using Square.Models;

namespace Square.Requests.Invoices;

/// <summary>
/// The inputs of the CreateInvoiceAttachment operation.
/// </summary>
public sealed record CreateInvoiceAttachmentOperationRequest
{
    /// <summary>
    /// The ID of the <see href="entity:Invoice">invoice</see> to attach the file to.
    /// </summary>
    public required string InvoiceId { get; init; }

    /// <summary>
    /// Represents a <see href="api-endpoint:Invoices-CreateInvoiceAttachment">CreateInvoiceAttachment</see> request.
    /// </summary>
    public CreateInvoiceAttachmentRequest? Request { get; init; }

    public BinaryContent? ImageFile { get; init; }
}

namespace Square.Requests.Invoices;

/// <summary>
/// The inputs of the DeleteInvoiceAttachment operation.
/// </summary>
public sealed record DeleteInvoiceAttachmentRequest
{
    /// <summary>
    /// The ID of the <see href="entity:Invoice">invoice</see> to delete the attachment from.
    /// </summary>
    public required string InvoiceId { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:InvoiceAttachment">attachment</see> to delete.
    /// </summary>
    public required string AttachmentId { get; init; }
}

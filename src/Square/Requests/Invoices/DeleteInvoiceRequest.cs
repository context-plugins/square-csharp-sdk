namespace Square.Requests.Invoices;

/// <summary>
/// The inputs of the DeleteInvoice operation.
/// </summary>
public sealed record DeleteInvoiceRequest
{
    /// <summary>
    /// The ID of the invoice to delete.
    /// </summary>
    public required string InvoiceId { get; init; }

    /// <summary>
    /// The version of the <see href="entity:Invoice">invoice</see> to delete.
    /// If you do not know the version, you can call <see href="api-endpoint:Invoices-GetInvoice">GetInvoice</see> or
    /// <see href="api-endpoint:Invoices-ListInvoices">ListInvoices</see>.
    /// </summary>
    public int? Version { get; init; }
}

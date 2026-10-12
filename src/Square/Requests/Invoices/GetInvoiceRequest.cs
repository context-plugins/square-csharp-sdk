namespace Square.Requests.Invoices;

/// <summary>
/// The inputs of the GetInvoice operation.
/// </summary>
public sealed record GetInvoiceRequest
{
    /// <summary>
    /// The ID of the invoice to retrieve.
    /// </summary>
    public required string InvoiceId { get; init; }
}

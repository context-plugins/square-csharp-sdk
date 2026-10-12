using Square.Models;

namespace Square.Requests.Invoices;

/// <summary>
/// The inputs of the PublishInvoice operation.
/// </summary>
public sealed record PublishInvoiceOperationRequest
{
    /// <summary>
    /// The ID of the invoice to publish.
    /// </summary>
    public required string InvoiceId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required PublishInvoiceRequest Body { get; init; }
}

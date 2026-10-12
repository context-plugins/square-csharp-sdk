using Square.Models;

namespace Square.Requests.Invoices;

/// <summary>
/// The inputs of the UpdateInvoice operation.
/// </summary>
public sealed record UpdateInvoiceOperationRequest
{
    /// <summary>
    /// The ID of the invoice to update.
    /// </summary>
    public required string InvoiceId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateInvoiceRequest Body { get; init; }
}

using Square.Models;

namespace Square.Requests.Invoices;

/// <summary>
/// The inputs of the CreateInvoice operation.
/// </summary>
public sealed record CreateInvoiceOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateInvoiceRequest Body { get; init; }
}

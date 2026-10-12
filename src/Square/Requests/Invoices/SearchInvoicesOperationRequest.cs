using Square.Models;

namespace Square.Requests.Invoices;

/// <summary>
/// The inputs of the SearchInvoices operation.
/// </summary>
public sealed record SearchInvoicesOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required SearchInvoicesRequest Body { get; init; }
}

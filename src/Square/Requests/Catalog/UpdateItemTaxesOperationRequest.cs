using Square.Models;

namespace Square.Requests.Catalog;

/// <summary>
/// The inputs of the UpdateItemTaxes operation.
/// </summary>
public sealed record UpdateItemTaxesOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateItemTaxesRequest Body { get; init; }
}

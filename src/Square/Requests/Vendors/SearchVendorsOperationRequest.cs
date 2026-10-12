using Square.Models;

namespace Square.Requests.Vendors;

/// <summary>
/// The inputs of the SearchVendors operation.
/// </summary>
public sealed record SearchVendorsOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required SearchVendorsRequest Body { get; init; }
}

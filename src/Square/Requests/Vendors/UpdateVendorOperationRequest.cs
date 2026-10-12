using Square.Models;

namespace Square.Requests.Vendors;

/// <summary>
/// The inputs of the UpdateVendor operation.
/// </summary>
public sealed record UpdateVendorOperationRequest
{
    public required string VendorId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateVendorRequest Body { get; init; }
}

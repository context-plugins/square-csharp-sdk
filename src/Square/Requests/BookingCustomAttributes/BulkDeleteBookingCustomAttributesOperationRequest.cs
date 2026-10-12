using Square.Models;

namespace Square.Requests.BookingCustomAttributes;

/// <summary>
/// The inputs of the BulkDeleteBookingCustomAttributes operation.
/// </summary>
public sealed record BulkDeleteBookingCustomAttributesOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required BulkDeleteBookingCustomAttributesRequest Body { get; init; }
}

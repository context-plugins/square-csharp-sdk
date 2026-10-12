using Square.Models;

namespace Square.Requests.BookingCustomAttributes;

/// <summary>
/// The inputs of the BulkUpsertBookingCustomAttributes operation.
/// </summary>
public sealed record BulkUpsertBookingCustomAttributesOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required BulkUpsertBookingCustomAttributesRequest Body { get; init; }
}

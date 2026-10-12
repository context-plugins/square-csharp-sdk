using Square.Models;

namespace Square.Requests.Bookings;

/// <summary>
/// The inputs of the CreateBooking operation.
/// </summary>
public sealed record CreateBookingOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateBookingRequest Body { get; init; }
}

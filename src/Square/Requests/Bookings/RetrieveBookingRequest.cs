namespace Square.Requests.Bookings;

/// <summary>
/// The inputs of the RetrieveBooking operation.
/// </summary>
public sealed record RetrieveBookingRequest
{
    /// <summary>
    /// The ID of the <see href="entity:Booking">Booking</see> object representing the to-be-retrieved booking.
    /// </summary>
    public required string BookingId { get; init; }
}

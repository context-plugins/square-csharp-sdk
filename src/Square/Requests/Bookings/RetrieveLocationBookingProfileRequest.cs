namespace Square.Requests.Bookings;

/// <summary>
/// The inputs of the RetrieveLocationBookingProfile operation.
/// </summary>
public sealed record RetrieveLocationBookingProfileRequest
{
    /// <summary>
    /// The ID of the location to retrieve the booking profile.
    /// </summary>
    public required string LocationId { get; init; }
}

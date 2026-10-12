namespace Square.Requests.Bookings;

/// <summary>
/// The inputs of the RetrieveTeamMemberBookingProfile operation.
/// </summary>
public sealed record RetrieveTeamMemberBookingProfileRequest
{
    /// <summary>
    /// The ID of the team member to retrieve.
    /// </summary>
    public required string TeamMemberId { get; init; }
}

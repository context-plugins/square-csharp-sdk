namespace Square.Requests.Bookings;

/// <summary>
/// The inputs of the ListTeamMemberBookingProfiles operation.
/// </summary>
public sealed record ListTeamMemberBookingProfilesRequest
{
    /// <summary>
    /// Indicates whether to include only bookable team members in the returned result (<c>true</c>) or not (<c>false</c>).
    /// </summary>
    public bool BookableOnly { get; init; } = false;

    /// <summary>
    /// The maximum number of results to return in a paged response.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The pagination cursor from the preceding response to return the next page of the results. Do not set this when retrieving the first page of the results.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// Indicates whether to include only team members enabled at the given location in the returned result.
    /// </summary>
    public string? LocationId { get; init; }
}

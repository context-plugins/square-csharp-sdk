namespace Square.Requests.Bookings;

/// <summary>
/// The inputs of the ListLocationBookingProfiles operation.
/// </summary>
public sealed record ListLocationBookingProfilesRequest
{
    /// <summary>
    /// The maximum number of results to return in a paged response.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The pagination cursor from the preceding response to return the next page of the results. Do not set this when retrieving the first page of the results.
    /// </summary>
    public string? Cursor { get; init; }
}

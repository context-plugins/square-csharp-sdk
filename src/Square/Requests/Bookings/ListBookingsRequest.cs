namespace Square.Requests.Bookings;

/// <summary>
/// The inputs of the ListBookings operation.
/// </summary>
public sealed record ListBookingsRequest
{
    /// <summary>
    /// The maximum number of results per page to return in a paged response.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The pagination cursor from the preceding response to return the next page of the results. Do not set this when retrieving the first page of the results.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// The <see href="entity:Customer">customer</see> for whom to retrieve bookings. If this is not set, bookings for all customers are retrieved.
    /// </summary>
    public string? CustomerId { get; init; }

    /// <summary>
    /// The team member for whom to retrieve bookings. If this is not set, bookings of all members are retrieved.
    /// </summary>
    public string? TeamMemberId { get; init; }

    /// <summary>
    /// The location for which to retrieve bookings. If this is not set, all locations' bookings are retrieved.
    /// </summary>
    public string? LocationId { get; init; }

    /// <summary>
    /// The RFC 3339 timestamp specifying the earliest of the start time. If this is not set, the current time is used.
    /// </summary>
    public string? StartAtMin { get; init; }

    /// <summary>
    /// The RFC 3339 timestamp specifying the latest of the start time. If this is not set, the time of 31 days after <c>start_at_min</c> is used.
    /// </summary>
    public string? StartAtMax { get; init; }
}

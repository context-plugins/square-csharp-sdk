namespace Square.Requests.CashDrawers;

/// <summary>
/// The inputs of the ListCashDrawerShiftEvents operation.
/// </summary>
public sealed record ListCashDrawerShiftEventsRequest
{
    /// <summary>
    /// The shift ID.
    /// </summary>
    public required string ShiftId { get; init; }

    /// <summary>
    /// The ID of the location to list cash drawer shifts for.
    /// </summary>
    public required string LocationId { get; init; }

    /// <summary>
    /// Number of resources to be returned in a page of results (200 by
    /// default, 1000 max).
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Opaque cursor for fetching the next page of results.
    /// </summary>
    public string? Cursor { get; init; }
}

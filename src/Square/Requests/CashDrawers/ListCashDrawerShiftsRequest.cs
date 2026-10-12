using Square.Models.Enums;

namespace Square.Requests.CashDrawers;

/// <summary>
/// The inputs of the ListCashDrawerShifts operation.
/// </summary>
public sealed record ListCashDrawerShiftsRequest
{
    /// <summary>
    /// The ID of the location to query for a list of cash drawer shifts.
    /// </summary>
    public required string LocationId { get; init; }

    /// <summary>
    /// The order in which cash drawer shifts are listed in the response,
    /// based on their opened_at field. Default value: ASC
    /// </summary>
    public SortOrder? SortOrder { get; init; }

    /// <summary>
    /// The inclusive start time of the query on opened_at, in ISO 8601 format.
    /// </summary>
    public string? BeginTime { get; init; }

    /// <summary>
    /// The exclusive end date of the query on opened_at, in ISO 8601 format.
    /// </summary>
    public string? EndTime { get; init; }

    /// <summary>
    /// Number of cash drawer shift events in a page of results (200 by
    /// default, 1000 max).
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Opaque cursor for fetching the next page of results.
    /// </summary>
    public string? Cursor { get; init; }
}

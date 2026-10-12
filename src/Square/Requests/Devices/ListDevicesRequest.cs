using Square.Models.Enums;

namespace Square.Requests.Devices;

/// <summary>
/// The inputs of the ListDevices operation.
/// </summary>
public sealed record ListDevicesRequest
{
    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this cursor to retrieve the next set of results for the original query.
    /// See <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see> for more information.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// The order in which results are listed.
    /// - <c>ASC</c> - Oldest to newest.
    /// - <c>DESC</c> - Newest to oldest (default).
    /// </summary>
    public SortOrder? SortOrder { get; init; }

    /// <summary>
    /// The number of results to return in a single page.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// If present, only returns devices at the target location.
    /// </summary>
    public string? LocationId { get; init; }
}

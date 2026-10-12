using Square.Models.Enums;

namespace Square.Requests.Disputes;

/// <summary>
/// The inputs of the ListDisputes operation.
/// </summary>
public sealed record ListDisputesRequest
{
    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this cursor to retrieve the next set of results for the original query.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// The dispute states used to filter the result. If not specified, the endpoint returns all disputes.
    /// </summary>
    public DisputeState? States { get; init; }

    /// <summary>
    /// The ID of the location for which to return a list of disputes.
    /// If not specified, the endpoint returns disputes associated with all locations.
    /// </summary>
    public string? LocationId { get; init; }
}

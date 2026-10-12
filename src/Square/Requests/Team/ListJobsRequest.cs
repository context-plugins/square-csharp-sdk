namespace Square.Requests.Team;

/// <summary>
/// The inputs of the ListJobs operation.
/// </summary>
public sealed record ListJobsRequest
{
    /// <summary>
    /// The pagination cursor returned by the previous call to this endpoint. Provide this
    /// cursor to retrieve the next page of results for your original request. For more information,
    /// see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    public string? Cursor { get; init; }
}

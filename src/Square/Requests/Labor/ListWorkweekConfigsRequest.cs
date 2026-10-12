namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the ListWorkweekConfigs operation.
/// </summary>
public sealed record ListWorkweekConfigsRequest
{
    /// <summary>
    /// The maximum number of <c>WorkweekConfigs</c> results to return per page.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// A pointer to the next page of <c>WorkweekConfig</c> results to fetch.
    /// </summary>
    public string? Cursor { get; init; }
}

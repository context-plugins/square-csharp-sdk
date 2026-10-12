namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the ListBreakTypes operation.
/// </summary>
public sealed record ListBreakTypesRequest
{
    /// <summary>
    /// Filter the returned <c>BreakType</c> results to only those that are associated with the
    /// specified location.
    /// </summary>
    public string? LocationId { get; init; }

    /// <summary>
    /// The maximum number of <c>BreakType</c> results to return per page. The number can range between 1
    /// and 200. The default is 200.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// A pointer to the next page of <c>BreakType</c> results to fetch.
    /// </summary>
    public string? Cursor { get; init; }
}

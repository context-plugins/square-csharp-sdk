namespace Square.Requests.Disputes;

/// <summary>
/// The inputs of the ListDisputeEvidence operation.
/// </summary>
public sealed record ListDisputeEvidenceRequest
{
    /// <summary>
    /// The ID of the dispute.
    /// </summary>
    public required string DisputeId { get; init; }

    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this cursor to retrieve the next set of results for the original query.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    public string? Cursor { get; init; }
}

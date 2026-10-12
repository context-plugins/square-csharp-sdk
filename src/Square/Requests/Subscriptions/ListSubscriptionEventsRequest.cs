namespace Square.Requests.Subscriptions;

/// <summary>
/// The inputs of the ListSubscriptionEvents operation.
/// </summary>
public sealed record ListSubscriptionEventsRequest
{
    /// <summary>
    /// The ID of the subscription to retrieve the events for.
    /// </summary>
    public required string SubscriptionId { get; init; }

    /// <summary>
    /// When the total number of resulting subscription events exceeds the limit of a paged response,
    /// specify the cursor returned from a preceding response here to fetch the next set of results.
    /// If the cursor is unset, the response contains the last page of the results.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// The upper limit on the number of subscription events to return
    /// in a paged response.
    /// </summary>
    public int? Limit { get; init; }
}

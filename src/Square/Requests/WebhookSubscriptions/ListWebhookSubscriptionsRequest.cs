using Square.Models.Enums;

namespace Square.Requests.WebhookSubscriptions;

/// <summary>
/// The inputs of the ListWebhookSubscriptions operation.
/// </summary>
public sealed record ListWebhookSubscriptionsRequest
{
    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this to retrieve the next set of results for your original query.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// Includes disabled <see href="entity:WebhookSubscription">Subscription</see>s.
    /// By default, all enabled <see href="entity:WebhookSubscription">Subscription</see>s are returned.
    /// </summary>
    public bool IncludeDisabled { get; init; } = false;

    /// <summary>
    /// Sorts the returned list by when the <see href="entity:WebhookSubscription">Subscription</see> was created with the specified order.
    /// This field defaults to ASC.
    /// </summary>
    public SortOrder? SortOrder { get; init; }

    /// <summary>
    /// The maximum number of results to be returned in a single page.
    /// It is possible to receive fewer results than the specified limit on a given page.
    /// The default value of 100 is also the maximum allowed value.
    /// <para>
    /// Default: 100
    /// </para>
    /// </summary>
    public int? Limit { get; init; }
}

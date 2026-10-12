namespace Square.Requests.Subscriptions;

/// <summary>
/// The inputs of the RetrieveSubscription operation.
/// </summary>
public sealed record RetrieveSubscriptionRequest
{
    /// <summary>
    /// The ID of the subscription to retrieve.
    /// </summary>
    public required string SubscriptionId { get; init; }

    /// <summary>
    /// A query parameter to specify related information to be included in the response.
    /// <para>
    /// The supported query parameter values are:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>actions</c>: to include scheduled actions on the targeted subscription.</description></item>
    /// </list>
    /// </summary>
    public string? Include { get; init; }
}

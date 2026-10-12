namespace Square.Requests.Subscriptions;

/// <summary>
/// The inputs of the CancelSubscription operation.
/// </summary>
public sealed record CancelSubscriptionRequest
{
    /// <summary>
    /// The ID of the subscription to cancel.
    /// </summary>
    public required string SubscriptionId { get; init; }
}

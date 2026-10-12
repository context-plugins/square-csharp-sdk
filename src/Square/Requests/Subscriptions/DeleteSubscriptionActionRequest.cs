namespace Square.Requests.Subscriptions;

/// <summary>
/// The inputs of the DeleteSubscriptionAction operation.
/// </summary>
public sealed record DeleteSubscriptionActionRequest
{
    /// <summary>
    /// The ID of the subscription the targeted action is to act upon.
    /// </summary>
    public required string SubscriptionId { get; init; }

    /// <summary>
    /// The ID of the targeted action to be deleted.
    /// </summary>
    public required string ActionId { get; init; }
}

namespace Square.Requests.WebhookSubscriptions;

/// <summary>
/// The inputs of the RetrieveWebhookSubscription operation.
/// </summary>
public sealed record RetrieveWebhookSubscriptionRequest
{
    /// <summary>
    /// [REQUIRED] The ID of the <see href="entity:WebhookSubscription">Subscription</see> to retrieve.
    /// </summary>
    public required string SubscriptionId { get; init; }
}

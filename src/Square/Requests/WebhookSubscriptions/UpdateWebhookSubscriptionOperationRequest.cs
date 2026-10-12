using Square.Models;

namespace Square.Requests.WebhookSubscriptions;

/// <summary>
/// The inputs of the UpdateWebhookSubscription operation.
/// </summary>
public sealed record UpdateWebhookSubscriptionOperationRequest
{
    /// <summary>
    /// [REQUIRED] The ID of the <see href="entity:WebhookSubscription">Subscription</see> to update.
    /// </summary>
    public required string SubscriptionId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateWebhookSubscriptionRequest Body { get; init; }
}

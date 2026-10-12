using Square.Models;

namespace Square.Requests.WebhookSubscriptions;

/// <summary>
/// The inputs of the CreateWebhookSubscription operation.
/// </summary>
public sealed record CreateWebhookSubscriptionOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateWebhookSubscriptionRequest Body { get; init; }
}

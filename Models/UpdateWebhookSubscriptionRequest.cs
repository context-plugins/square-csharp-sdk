using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Updates a <see href="entity:WebhookSubscription">Subscription</see>.
/// </summary>
public record UpdateWebhookSubscriptionRequest
{
    /// <summary>
    /// Represents the details of a webhook subscription, including notification URL,
    /// event types, and signature key.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription")]
    public WebhookSubscription? Subscription { get; init; }
}

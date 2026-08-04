using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Creates a <see href="entity:WebhookSubscription">Subscription</see>.
/// </summary>
public record CreateWebhookSubscriptionRequest
{
    /// <summary>
    /// A unique string that identifies the <see href="api-endpoint:WebhookSubscriptions-CreateWebhookSubscription">CreateWebhookSubscription</see> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [MaxLength(45)]
    public string? IdempotencyKey { get; init; }

    /// <summary>
    /// Represents the details of a webhook subscription, including notification URL,
    /// event types, and signature key.
    /// </summary>
    [JsonPropertyName("subscription")]
    public required WebhookSubscription Subscription { get; init; }
}

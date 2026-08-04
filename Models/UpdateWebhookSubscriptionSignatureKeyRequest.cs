using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Updates a <see href="entity:WebhookSubscription">Subscription</see> by replacing the existing signature key with a new one.
/// </summary>
public record UpdateWebhookSubscriptionSignatureKeyRequest
{
    /// <summary>
    /// A unique string that identifies the <see href="api-endpoint:WebhookSubscriptions-UpdateWebhookSubscriptionSignatureKey">UpdateWebhookSubscriptionSignatureKey</see> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [MaxLength(45)]
    public string? IdempotencyKey { get; init; }
}

using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Tests a <see href="entity:WebhookSubscription">Subscription</see> by sending a test event to its notification URL.
/// </summary>
public record TestWebhookSubscriptionRequest
{
    /// <summary>
    /// The event type that will be used to test the <see href="entity:WebhookSubscription">Subscription</see>. The event type must be
    /// contained in the list of event types in the <see href="entity:WebhookSubscription">Subscription</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event_type")]
    public string? EventType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

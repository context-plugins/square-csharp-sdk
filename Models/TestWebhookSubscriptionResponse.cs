using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the <see href="api-endpoint:WebhookSubscriptions-TestWebhookSubscription">TestWebhookSubscription</see> endpoint.
/// <para>
/// Note: If there are errors processing the request, the <see href="entity:SubscriptionTestResult">SubscriptionTestResult</see> field is not
/// present.
/// </para>
/// </summary>
public record TestWebhookSubscriptionResponse
{
    /// <summary>
    /// Information on errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents the details of a webhook subscription, including notification URL,
    /// event types, and signature key.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription_test_result")]
    public SubscriptionTestResult? SubscriptionTestResult { get; init; }
}

using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines output parameters in a response from the
/// <see href="api-endpoint:Subscriptions-CancelSubscription">CancelSubscription</see> endpoint.
/// </summary>
public record CancelSubscriptionResponse
{
    /// <summary>
    /// Errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents a subscription purchased by a customer.
    /// <para>
    /// For more information, see
    /// <see href="https://developer.squareup.com/docs/subscriptions-api/manage-subscriptions">Manage Subscriptions</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription")]
    public Subscription? Subscription { get; init; }

    /// <summary>
    /// A list of a single <c>CANCEL</c> action scheduled for the subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actions")]
    public IReadOnlyList<SubscriptionAction>? Actions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

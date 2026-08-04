using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Defines output parameters in a response from the
/// <see href="api-endpoint:Subscriptions-CreateSubscription">CreateSubscription</see> endpoint.
/// </summary>
public record CreateSubscriptionResponse
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
}

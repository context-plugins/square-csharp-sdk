using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Describes changes to a subscription and the subscription status.
/// </summary>
public record SubscriptionEvent
{
    /// <summary>
    /// The ID of the subscription event.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Supported types of an event occurred to a subscription.
    /// </summary>
    [JsonPropertyName("subscription_event_type")]
    public required SubscriptionEventSubscriptionEventType SubscriptionEventType { get; init; }

    /// <summary>
    /// The <c>YYYY-MM-DD</c>-formatted date (for example, 2013-01-15) when the subscription event occurred.
    /// </summary>
    [JsonPropertyName("effective_date")]
    public required string EffectiveDate { get; init; }

    /// <summary>
    /// The day-of-the-month the billing anchor date was changed to, if applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("monthly_billing_anchor_date")]
    public int? MonthlyBillingAnchorDate { get; init; }

    /// <summary>
    /// Provides information about the subscription event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("info")]
    public SubscriptionEventInfo? Info { get; init; }

    /// <summary>
    /// A list of Phases, to pass phase-specific information used in the swap.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phases")]
    public IReadOnlyList<Phase>? Phases { get; init; }

    /// <summary>
    /// The ID of the subscription plan variation associated with the subscription.
    /// </summary>
    [JsonPropertyName("plan_variation_id")]
    public required string PlanVariationId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

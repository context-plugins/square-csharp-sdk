using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// Describes a subscription plan variation. A subscription plan variation represents how the subscription for a product or service is sold.
/// For more information, see <see href="https://developer.squareup.com/docs/subscriptions-api/plans-and-variations">Subscription Plans and Variations</see>.
/// </summary>
public record CatalogSubscriptionPlanVariation
{
    /// <summary>
    /// The name of the plan variation.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// A list containing each <see href="entity:SubscriptionPhase">SubscriptionPhase</see> for this plan variation.
    /// </summary>
    [JsonPropertyName("phases")]
    public required IReadOnlyList<SubscriptionPhase> Phases { get; init; }

    /// <summary>
    /// The id of the subscription plan, if there is one.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription_plan_id")]
    public string? SubscriptionPlanId { get; init; }

    /// <summary>
    /// The day of the month the billing period starts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("monthly_billing_anchor_date")]
    [Minimum(1)]
    [Maximum(31)]
    public long? MonthlyBillingAnchorDate { get; init; }

    /// <summary>
    /// Whether bills for this plan variation can be split for proration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_prorate")]
    public bool? CanProrate { get; init; }

    /// <summary>
    /// The ID of a "successor" plan variation to this one. If the field is set, and this object is disabled at all
    /// locations, it indicates that this variation is deprecated and the object identified by the successor ID be used in
    /// its stead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("successor_plan_variation_id")]
    public string? SuccessorPlanVariationId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

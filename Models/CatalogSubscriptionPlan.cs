using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Describes a subscription plan. A subscription plan represents what you want to sell in a subscription model, and includes references to each of the associated subscription plan variations.
/// For more information, see <see href="https://developer.squareup.com/docs/subscriptions-api/plans-and-variations">Subscription Plans and Variations</see>.
/// </summary>
public record CatalogSubscriptionPlan
{
    /// <summary>
    /// The name of the plan.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// A list of SubscriptionPhase containing the <see href="entity:SubscriptionPhase">SubscriptionPhase</see> for this plan.
    /// This field it required. Not including this field will throw a REQUIRED_FIELD_MISSING error
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phases")]
    public IReadOnlyList<SubscriptionPhase?>? Phases { get; init; }

    /// <summary>
    /// The list of subscription plan variations available for this product
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription_plan_variations")]
    public IReadOnlyList<CatalogObject?>? SubscriptionPlanVariations { get; init; }

    /// <summary>
    /// The list of IDs of <c>CatalogItems</c> that are eligible for subscription by this SubscriptionPlan's variations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eligible_item_ids")]
    public IReadOnlyList<string?>? EligibleItemIds { get; init; }

    /// <summary>
    /// The list of IDs of <c>CatalogCategory</c> that are eligible for subscription by this SubscriptionPlan's variations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eligible_category_ids")]
    public IReadOnlyList<string?>? EligibleCategoryIds { get; init; }

    /// <summary>
    /// If true, all items in the merchant's catalog are subscribable by this SubscriptionPlan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("all_items")]
    public bool? AllItems { get; init; }
}

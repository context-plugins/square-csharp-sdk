using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents an action as a pending change to a subscription.
/// </summary>
public record SubscriptionAction
{
    /// <summary>
    /// The ID of an action scoped to a subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Supported types of an action as a pending change to a subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public SubscriptionActionType? Type { get; init; }

    /// <summary>
    /// The <c>YYYY-MM-DD</c>-formatted date when the action occurs on the subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("effective_date")]
    public string? EffectiveDate { get; init; }

    /// <summary>
    /// The new billing anchor day value, for a <c>CHANGE_BILLING_ANCHOR_DATE</c> action.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("monthly_billing_anchor_date")]
    public int? MonthlyBillingAnchorDate { get; init; }

    /// <summary>
    /// A list of Phases, to pass phase-specific information used in the swap.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phases")]
    public IReadOnlyList<Phase?>? Phases { get; init; }

    /// <summary>
    /// The target subscription plan variation that a subscription switches to, for a <c>SWAP_PLAN</c> action.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("new_plan_variation_id")]
    public string? NewPlanVariationId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

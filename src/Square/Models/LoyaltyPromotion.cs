using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a promotion for a <see href="entity:LoyaltyProgram">loyalty program</see>. Loyalty promotions enable buyers
/// to earn extra points on top of those earned from the base program.
/// <para>
/// A loyalty program can have a maximum of 10 loyalty promotions with an <c>ACTIVE</c> or <c>SCHEDULED</c> status.
/// </para>
/// </summary>
public record LoyaltyPromotion
{
    /// <summary>
    /// The Square-assigned ID of the promotion.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [StringLength(255, MinimumLength = 1)]
    public string? Id { get; init; }

    /// <summary>
    /// The name of the promotion.
    /// </summary>
    [JsonPropertyName("name")]
    [StringLength(70, MinimumLength = 1)]
    public required string Name { get; init; }

    /// <summary>
    /// Represents how points for a <see href="entity:LoyaltyPromotion">loyalty promotion</see> are calculated,
    /// either by multiplying the points earned from the base program or by adding a specified number
    /// of points to the points earned from the base program.
    /// </summary>
    [JsonPropertyName("incentive")]
    public required LoyaltyPromotionIncentive Incentive { get; init; }

    /// <summary>
    /// Represents scheduling information that determines when purchases can qualify to earn points
    /// from a <see href="entity:LoyaltyPromotion">loyalty promotion</see>.
    /// </summary>
    [JsonPropertyName("available_time")]
    public required LoyaltyPromotionAvailableTimeData AvailableTime { get; init; }

    /// <summary>
    /// Represents the number of times a buyer can earn points during a <see href="entity:LoyaltyPromotion">loyalty promotion</see>.
    /// If this field is not set, buyers can trigger the promotion an unlimited number of times to earn points during
    /// the time that the promotion is available.
    /// <para>
    /// A purchase that is disqualified from earning points because of this limit might qualify for another active promotion.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trigger_limit")]
    public LoyaltyPromotionTriggerLimit? TriggerLimit { get; init; }

    /// <summary>
    /// Indicates the status of a <see href="entity:LoyaltyPromotion">loyalty promotion</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public LoyaltyPromotionStatus? Status { get; init; }

    /// <summary>
    /// The timestamp of when the promotion was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The timestamp of when the promotion was canceled, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("canceled_at")]
    public string? CanceledAt { get; init; }

    /// <summary>
    /// The timestamp when the promotion was last updated, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:LoyaltyProgram">loyalty program</see> associated with the promotion.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loyalty_program_id")]
    public string? LoyaltyProgramId { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minimum_spend_amount_money")]
    public Money? MinimumSpendAmountMoney { get; init; }

    /// <summary>
    /// The IDs of any qualifying <c>ITEM_VARIATION</c> <see href="entity:CatalogObject">catalog objects</see>. If specified,
    /// the purchase must include at least one of these items to qualify for the promotion.
    /// <para>
    /// This option is valid only if the base loyalty program uses a <c>VISIT</c> or <c>SPEND</c> accrual rule.
    /// With <c>SPEND</c> accrual rules, make sure that qualifying promotional items are not excluded.
    /// </para>
    /// <para>
    /// You can specify <c>qualifying_item_variation_ids</c> or <c>qualifying_category_ids</c> for a given promotion, but not both.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("qualifying_item_variation_ids")]
    public IReadOnlyList<string>? QualifyingItemVariationIds { get; init; }

    /// <summary>
    /// The IDs of any qualifying <c>CATEGORY</c> <see href="entity:CatalogObject">catalog objects</see>. If specified,
    /// the purchase must include at least one item from one of these categories to qualify for the promotion.
    /// <para>
    /// This option is valid only if the base loyalty program uses a <c>VISIT</c> or <c>SPEND</c> accrual rule.
    /// With <c>SPEND</c> accrual rules, make sure that qualifying promotional items are not excluded.
    /// </para>
    /// <para>
    /// You can specify <c>qualifying_category_ids</c> or <c>qualifying_item_variation_ids</c> for a promotion, but not both.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("qualifying_category_ids")]
    public IReadOnlyList<string>? QualifyingCategoryIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

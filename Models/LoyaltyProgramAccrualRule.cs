using System.Text.Json.Serialization;
using Square.Core.Validation.Attributes;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents an accrual rule, which defines how buyers can earn points from the base <see href="entity:LoyaltyProgram">loyalty program</see>.
/// </summary>
public record LoyaltyProgramAccrualRule
{
    /// <summary>
    /// The type of the accrual rule that defines how buyers can earn points.
    /// </summary>
    [JsonPropertyName("accrual_type")]
    public required LoyaltyProgramAccrualRuleType AccrualType { get; init; }

    /// <summary>
    /// The number of points that
    /// buyers earn based on the <c>accrual_type</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("points")]
    [Minimum(1)]
    public int? Points { get; init; }

    /// <summary>
    /// Represents additional data for rules with the <c>VISIT</c> accrual type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visit_data")]
    public LoyaltyProgramAccrualRuleVisitData? VisitData { get; init; }

    /// <summary>
    /// Represents additional data for rules with the <c>SPEND</c> accrual type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("spend_data")]
    public LoyaltyProgramAccrualRuleSpendData? SpendData { get; init; }

    /// <summary>
    /// Represents additional data for rules with the <c>ITEM_VARIATION</c> accrual type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_variation_data")]
    public LoyaltyProgramAccrualRuleItemVariationData? ItemVariationData { get; init; }

    /// <summary>
    /// Represents additional data for rules with the <c>CATEGORY</c> accrual type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category_data")]
    public LoyaltyProgramAccrualRuleCategoryData? CategoryData { get; init; }
}

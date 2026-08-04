using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a Square loyalty program. Loyalty programs define how buyers can earn points and redeem points for rewards.
/// Square sellers can have only one loyalty program, which is created and managed from the Seller Dashboard.
/// For more information, see <see href="https://developer.squareup.com/docs/loyalty/overview">Loyalty Program Overview</see>.
/// </summary>
public record LoyaltyProgram
{
    /// <summary>
    /// The Square-assigned ID of the loyalty program. Updates to
    /// the loyalty program do not modify the identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(36)]
    public string? Id { get; init; }

    /// <summary>
    /// Indicates whether the program is currently active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public LoyaltyProgramStatus? Status { get; init; }

    /// <summary>
    /// The list of rewards for buyers, sorted by ascending points.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reward_tiers")]
    public IReadOnlyList<LoyaltyProgramRewardTier?>? RewardTiers { get; init; }

    /// <summary>
    /// Describes when the loyalty program expires.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiration_policy")]
    public LoyaltyProgramExpirationPolicy? ExpirationPolicy { get; init; }

    /// <summary>
    /// Represents the naming used for loyalty points.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminology")]
    public LoyaltyProgramTerminology? Terminology { get; init; }

    /// <summary>
    /// The <see href="entity:Location">locations</see> at which the program is active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_ids")]
    public IReadOnlyList<string?>? LocationIds { get; init; }

    /// <summary>
    /// The timestamp when the program was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The timestamp when the reward was last updated, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// Defines how buyers can earn loyalty points from the base loyalty program.
    /// To check for associated <see href="entity:LoyaltyPromotion">loyalty promotions</see> that enable
    /// buyers to earn extra points, call <see href="api-endpoint:Loyalty-ListLoyaltyPromotions">ListLoyaltyPromotions</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accrual_rules")]
    public IReadOnlyList<LoyaltyProgramAccrualRule?>? AccrualRules { get; init; }
}

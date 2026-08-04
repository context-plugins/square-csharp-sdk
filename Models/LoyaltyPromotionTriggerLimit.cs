using System.Text.Json.Serialization;
using Square.Core.Validation.Attributes;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents the number of times a buyer can earn points during a <see href="entity:LoyaltyPromotion">loyalty promotion</see>.
/// If this field is not set, buyers can trigger the promotion an unlimited number of times to earn points during
/// the time that the promotion is available.
/// <para>
/// A purchase that is disqualified from earning points because of this limit might qualify for another active promotion.
/// </para>
/// </summary>
public record LoyaltyPromotionTriggerLimit
{
    /// <summary>
    /// The maximum number of times a buyer can trigger the promotion during the specified <c>interval</c>.
    /// </summary>
    [JsonPropertyName("times")]
    [Minimum(1)]
    [Maximum(30)]
    public required int Times { get; init; }

    /// <summary>
    /// Indicates the time period that the <see href="entity:LoyaltyPromotionTriggerLimit">trigger limit</see> applies to,
    /// which is used to determine the number of times a buyer can earn points for a <see href="entity:LoyaltyPromotion">loyalty promotion</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interval")]
    public LoyaltyPromotionTriggerLimitInterval? Interval { get; init; }
}

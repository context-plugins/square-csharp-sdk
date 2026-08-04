using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// Represents the metadata for a <c>POINTS_MULTIPLIER</c> type of <see href="entity:LoyaltyPromotionIncentive">loyalty promotion incentive</see>.
/// </summary>
public record LoyaltyPromotionIncentivePointsMultiplierData
{
    /// <summary>
    /// The multiplier used to calculate the number of points earned each time the promotion
    /// is triggered. For example, suppose a purchase qualifies for 5 points from the base loyalty program.
    /// If the purchase also qualifies for a <c>POINTS_MULTIPLIER</c> promotion incentive with a <c>points_multiplier</c>
    /// of 3, the buyer earns a total of 15 points (5 program points x 3 promotion multiplier = 15 points).
    /// <para>
    /// DEPRECATED at version 2023-08-16. Replaced by the <c>multiplier</c> field.
    /// </para>
    /// <para>
    /// One of the following is required when specifying a points multiplier:
    /// - (Recommended) The <c>multiplier</c> field.
    /// - This deprecated <c>points_multiplier</c> field. If provided in the request, Square also returns <c>multiplier</c>
    /// with the equivalent value.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("points_multiplier")]
    [Minimum(2)]
    [Maximum(10)]
    public int? PointsMultiplier { get; init; }

    /// <summary>
    /// The multiplier used to calculate the number of points earned each time the promotion is triggered,
    /// specified as a string representation of a decimal. Square supports multipliers up to 10x, with three
    /// point precision for decimal multipliers. For example, suppose a purchase qualifies for 4 points from the
    /// base loyalty program. If the purchase also qualifies for a <c>POINTS_MULTIPLIER</c> promotion incentive with a
    /// <c>multiplier</c> of "1.5", the buyer earns a total of 6 points (4 program points x 1.5 promotion multiplier = 6 points).
    /// Fractional points are dropped.
    /// <para>
    /// One of the following is required when specifying a points multiplier:
    /// - (Recommended) This <c>multiplier</c> field.
    /// - The deprecated <c>points_multiplier</c> field. If provided in the request, Square also returns <c>multiplier</c>
    /// with the equivalent value.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("multiplier")]
    [MaxLength(5)]
    public string? Multiplier { get; init; }
}

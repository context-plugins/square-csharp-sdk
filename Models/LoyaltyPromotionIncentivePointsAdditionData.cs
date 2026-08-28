using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// Represents the metadata for a <c>POINTS_ADDITION</c> type of <see href="entity:LoyaltyPromotionIncentive">loyalty promotion incentive</see>.
/// </summary>
public record LoyaltyPromotionIncentivePointsAdditionData
{
    /// <summary>
    /// The number of additional points to earn each time the promotion is triggered. For example,
    /// suppose a purchase qualifies for 5 points from the base loyalty program. If the purchase also
    /// qualifies for a <c>POINTS_ADDITION</c> promotion incentive with a <c>points_addition</c> of 3, the buyer
    /// earns a total of 8 points (5 program points + 3 promotion points = 8 points).
    /// </summary>
    [JsonPropertyName("points_addition")]
    [Minimum(1)]
    public required int PointsAddition { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

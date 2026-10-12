using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the type of points incentive for a <see href="entity:LoyaltyPromotion">loyalty promotion</see>,
/// which is used to determine how buyers can earn points from the promotion.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyPromotionIncentiveType>))]
public sealed record LoyaltyPromotionIncentiveType : OpenStringEnum<LoyaltyPromotionIncentiveType>
{
    private LoyaltyPromotionIncentiveType(string value) : base(value)
    {
    }

    /// <summary>
    /// Multiply the number of points earned from the base loyalty program.
    /// For example, "Earn double points."
    /// </summary>
    public static readonly LoyaltyPromotionIncentiveType PointsMultiplier = new("POINTS_MULTIPLIER");

    /// <summary>
    /// Add a specified number of points to those earned from the base loyalty program.
    /// For example, "Earn 10 additional points."
    /// </summary>
    public static readonly LoyaltyPromotionIncentiveType PointsAddition = new("POINTS_ADDITION");

    public TResult Match<TResult>(Func<TResult> onPointsMultiplier,
        Func<TResult> onPointsAddition,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PointsMultiplier => onPointsMultiplier(),
            _ when this == PointsAddition => onPointsAddition(),
            _ => otherwise(Value)
        };

    public void Match(Action onPointsMultiplier, Action onPointsAddition, Action<string> otherwise)
    {
        if (this == PointsMultiplier) onPointsMultiplier();
        else if (this == PointsAddition) onPointsAddition();
        else otherwise(Value);
    }
}

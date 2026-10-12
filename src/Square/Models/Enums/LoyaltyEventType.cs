using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The type of the loyalty event.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyEventType>))]
public sealed record LoyaltyEventType : OpenStringEnum<LoyaltyEventType>
{
    private LoyaltyEventType(string value) : base(value)
    {
    }

    /// <summary>
    /// Points are added to a loyalty account for a purchase that
    /// qualified for points based on an <see href="entity:LoyaltyProgramAccrualRule">accrual rule</see>.
    /// </summary>
    public static readonly LoyaltyEventType AccumulatePoints = new("ACCUMULATE_POINTS");

    /// <summary>
    /// A <see href="entity:LoyaltyReward">loyalty reward</see> is created.
    /// </summary>
    public static readonly LoyaltyEventType CreateReward = new("CREATE_REWARD");

    /// <summary>
    /// A loyalty reward is redeemed.
    /// </summary>
    public static readonly LoyaltyEventType RedeemReward = new("REDEEM_REWARD");

    /// <summary>
    /// A loyalty reward is deleted.
    /// </summary>
    public static readonly LoyaltyEventType DeleteReward = new("DELETE_REWARD");

    /// <summary>
    /// Loyalty points are manually adjusted.
    /// </summary>
    public static readonly LoyaltyEventType AdjustPoints = new("ADJUST_POINTS");

    /// <summary>
    /// Loyalty points are expired according to the
    /// expiration policy of the loyalty program.
    /// </summary>
    public static readonly LoyaltyEventType ExpirePoints = new("EXPIRE_POINTS");

    /// <summary>
    /// Some other loyalty event occurred.
    /// </summary>
    public static readonly LoyaltyEventType Other = new("OTHER");

    /// <summary>
    /// Points are added to a loyalty account for a purchase that
    /// qualified for a <see href="entity:LoyaltyPromotion">loyalty promotion</see>.
    /// </summary>
    public static readonly LoyaltyEventType AccumulatePromotionPoints = new("ACCUMULATE_PROMOTION_POINTS");

    public TResult Match<TResult>(Func<TResult> onAccumulatePoints,
        Func<TResult> onCreateReward,
        Func<TResult> onRedeemReward,
        Func<TResult> onDeleteReward,
        Func<TResult> onAdjustPoints,
        Func<TResult> onExpirePoints,
        Func<TResult> onOther,
        Func<TResult> onAccumulatePromotionPoints,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccumulatePoints => onAccumulatePoints(),
            _ when this == CreateReward => onCreateReward(),
            _ when this == RedeemReward => onRedeemReward(),
            _ when this == DeleteReward => onDeleteReward(),
            _ when this == AdjustPoints => onAdjustPoints(),
            _ when this == ExpirePoints => onExpirePoints(),
            _ when this == Other => onOther(),
            _ when this == AccumulatePromotionPoints => onAccumulatePromotionPoints(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccumulatePoints,
        Action onCreateReward,
        Action onRedeemReward,
        Action onDeleteReward,
        Action onAdjustPoints,
        Action onExpirePoints,
        Action onOther,
        Action onAccumulatePromotionPoints,
        Action<string> otherwise)
    {
        if (this == AccumulatePoints) onAccumulatePoints();
        else if (this == CreateReward) onCreateReward();
        else if (this == RedeemReward) onRedeemReward();
        else if (this == DeleteReward) onDeleteReward();
        else if (this == AdjustPoints) onAdjustPoints();
        else if (this == ExpirePoints) onExpirePoints();
        else if (this == Other) onOther();
        else if (this == AccumulatePromotionPoints) onAccumulatePromotionPoints();
        else otherwise(Value);
    }
}

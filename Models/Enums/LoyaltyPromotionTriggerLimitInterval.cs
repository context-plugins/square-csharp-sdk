using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the time period that the <see href="entity:LoyaltyPromotionTriggerLimit">trigger limit</see> applies to,
/// which is used to determine the number of times a buyer can earn points for a <see href="entity:LoyaltyPromotion">loyalty promotion</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyPromotionTriggerLimitInterval>))]
public sealed record LoyaltyPromotionTriggerLimitInterval : StringEnum<LoyaltyPromotionTriggerLimitInterval>
{
    private LoyaltyPromotionTriggerLimitInterval(string value) : base(value)
    {
    }

    /// <summary>
    /// The limit applies to the entire time that the promotion is active. For example, if <c>times</c>
    /// is set to 1 and <c>time_period</c> is set to <c>ALL_TIME</c>, a buyer can earn promotion points a maximum
    /// of one time during the promotion.
    /// </summary>
    public static readonly LoyaltyPromotionTriggerLimitInterval AllTime = new("ALL_TIME");

    /// <summary>
    /// The limit applies per day, according to the <c>available_time</c> schedule specified for the promotion.
    /// For example, if the <c>times</c> field of the trigger limit is set to 1, a buyer can trigger the promotion
    /// a maximum of once per day.
    /// </summary>
    public static readonly LoyaltyPromotionTriggerLimitInterval Day = new("DAY");

    public static LoyaltyPromotionTriggerLimitInterval FromValue(string value) => FromValueCore(value);
}

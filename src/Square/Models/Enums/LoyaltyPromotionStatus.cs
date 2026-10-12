using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the status of a <see href="entity:LoyaltyPromotion">loyalty promotion</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyPromotionStatus>))]
public sealed record LoyaltyPromotionStatus : OpenStringEnum<LoyaltyPromotionStatus>
{
    private LoyaltyPromotionStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The loyalty promotion is currently active. Buyers can earn points for purchases
    /// that meet the promotion conditions, such as the promotion's <c>available_time</c>.
    /// </summary>
    public static readonly LoyaltyPromotionStatus Active = new("ACTIVE");

    /// <summary>
    /// The loyalty promotion has ended because the specified <c>end_date</c> was reached.
    /// <c>ENDED</c> is a terminal status.
    /// </summary>
    public static readonly LoyaltyPromotionStatus Ended = new("ENDED");

    /// <summary>
    /// The loyalty promotion was canceled. <c>CANCELED</c> is a terminal status.
    /// </summary>
    public static readonly LoyaltyPromotionStatus Canceled = new("CANCELED");

    /// <summary>
    /// The loyalty promotion is scheduled to start in the future. Square changes the
    /// promotion status to <c>ACTIVE</c> when the <c>start_date</c> is reached.
    /// </summary>
    public static readonly LoyaltyPromotionStatus Scheduled = new("SCHEDULED");

    public TResult Match<TResult>(Func<TResult> onActive,
        Func<TResult> onEnded,
        Func<TResult> onCanceled,
        Func<TResult> onScheduled,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Ended => onEnded(),
            _ when this == Canceled => onCanceled(),
            _ when this == Scheduled => onScheduled(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive, Action onEnded, Action onCanceled, Action onScheduled, Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Ended) onEnded();
        else if (this == Canceled) onCanceled();
        else if (this == Scheduled) onScheduled();
        else otherwise(Value);
    }
}

using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The status of the loyalty reward.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyRewardStatus>))]
public sealed record LoyaltyRewardStatus : OpenStringEnum<LoyaltyRewardStatus>
{
    private LoyaltyRewardStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The reward is issued.
    /// </summary>
    public static readonly LoyaltyRewardStatus Issued = new("ISSUED");

    /// <summary>
    /// The reward is redeemed.
    /// </summary>
    public static readonly LoyaltyRewardStatus Redeemed = new("REDEEMED");

    /// <summary>
    /// The reward is deleted.
    /// </summary>
    public static readonly LoyaltyRewardStatus Deleted = new("DELETED");

    public TResult Match<TResult>(Func<TResult> onIssued,
        Func<TResult> onRedeemed,
        Func<TResult> onDeleted,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Issued => onIssued(),
            _ when this == Redeemed => onRedeemed(),
            _ when this == Deleted => onDeleted(),
            _ => otherwise(Value)
        };

    public void Match(Action onIssued, Action onRedeemed, Action onDeleted, Action<string> otherwise)
    {
        if (this == Issued) onIssued();
        else if (this == Redeemed) onRedeemed();
        else if (this == Deleted) onDeleted();
        else otherwise(Value);
    }
}

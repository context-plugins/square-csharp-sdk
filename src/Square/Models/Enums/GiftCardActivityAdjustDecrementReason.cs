using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the reason for deducting money from a <see href="entity:GiftCard">gift card</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GiftCardActivityAdjustDecrementReason>))]
public sealed record GiftCardActivityAdjustDecrementReason : OpenStringEnum<GiftCardActivityAdjustDecrementReason>
{
    private GiftCardActivityAdjustDecrementReason(string value) : base(value)
    {
    }

    /// <summary>
    /// The balance was decreased because the seller detected suspicious or fraudulent activity
    /// on the gift card.
    /// </summary>
    public static readonly GiftCardActivityAdjustDecrementReason SuspiciousActivity = new("SUSPICIOUS_ACTIVITY");

    /// <summary>
    /// The balance was decreased to reverse an unintentional balance increase.
    /// </summary>
    public static readonly GiftCardActivityAdjustDecrementReason BalanceAccidentallyIncreased = new(
        "BALANCE_ACCIDENTALLY_INCREASED");

    /// <summary>
    /// The balance was decreased to accommodate support issues.
    /// </summary>
    public static readonly GiftCardActivityAdjustDecrementReason SupportIssue = new("SUPPORT_ISSUE");

    /// <summary>
    /// The balance was decreased because the order used to purchase or reload the
    /// gift card was refunded.
    /// </summary>
    public static readonly GiftCardActivityAdjustDecrementReason PurchaseWasRefunded = new("PURCHASE_WAS_REFUNDED");

    public TResult Match<TResult>(Func<TResult> onSuspiciousActivity,
        Func<TResult> onBalanceAccidentallyIncreased,
        Func<TResult> onSupportIssue,
        Func<TResult> onPurchaseWasRefunded,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SuspiciousActivity => onSuspiciousActivity(),
            _ when this == BalanceAccidentallyIncreased => onBalanceAccidentallyIncreased(),
            _ when this == SupportIssue => onSupportIssue(),
            _ when this == PurchaseWasRefunded => onPurchaseWasRefunded(),
            _ => otherwise(Value)
        };

    public void Match(Action onSuspiciousActivity,
        Action onBalanceAccidentallyIncreased,
        Action onSupportIssue,
        Action onPurchaseWasRefunded,
        Action<string> otherwise)
    {
        if (this == SuspiciousActivity) onSuspiciousActivity();
        else if (this == BalanceAccidentallyIncreased) onBalanceAccidentallyIncreased();
        else if (this == SupportIssue) onSupportIssue();
        else if (this == PurchaseWasRefunded) onPurchaseWasRefunded();
        else otherwise(Value);
    }
}

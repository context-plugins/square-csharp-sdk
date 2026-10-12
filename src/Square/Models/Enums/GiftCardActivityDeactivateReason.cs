using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the reason for deactivating a <see href="entity:GiftCard">gift card</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GiftCardActivityDeactivateReason>))]
public sealed record GiftCardActivityDeactivateReason : OpenStringEnum<GiftCardActivityDeactivateReason>
{
    private GiftCardActivityDeactivateReason(string value) : base(value)
    {
    }

    /// <summary>
    /// The seller suspects suspicious activity.
    /// </summary>
    public static readonly GiftCardActivityDeactivateReason SuspiciousActivity = new("SUSPICIOUS_ACTIVITY");

    /// <summary>
    /// The gift card was deactivated for an unknown reason.
    /// <para>
    /// This reason is read-only and cannot be used to create a <c>DEACTIVATE</c> activity using the Gift Card Activities API.
    /// </para>
    /// </summary>
    public static readonly GiftCardActivityDeactivateReason UnknownReason = new("UNKNOWN_REASON");

    /// <summary>
    /// A chargeback on the gift card purchase (or the gift card load) was ruled in favor of the buyer.
    /// <para>
    /// This reason is read-only and cannot be used to create a <c>DEACTIVATE</c> activity using the Gift Card Activities API.
    /// </para>
    /// </summary>
    public static readonly GiftCardActivityDeactivateReason ChargebackDeactivate = new("CHARGEBACK_DEACTIVATE");

    public TResult Match<TResult>(Func<TResult> onSuspiciousActivity,
        Func<TResult> onUnknownReason,
        Func<TResult> onChargebackDeactivate,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SuspiciousActivity => onSuspiciousActivity(),
            _ when this == UnknownReason => onUnknownReason(),
            _ when this == ChargebackDeactivate => onChargebackDeactivate(),
            _ => otherwise(Value)
        };

    public void Match(Action onSuspiciousActivity,
        Action onUnknownReason,
        Action onChargebackDeactivate,
        Action<string> otherwise)
    {
        if (this == SuspiciousActivity) onSuspiciousActivity();
        else if (this == UnknownReason) onUnknownReason();
        else if (this == ChargebackDeactivate) onChargebackDeactivate();
        else otherwise(Value);
    }
}

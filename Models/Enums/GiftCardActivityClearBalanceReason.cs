using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the reason for clearing the balance of a <see href="entity:GiftCard">gift card</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GiftCardActivityClearBalanceReason>))]
public sealed record GiftCardActivityClearBalanceReason : StringEnum<GiftCardActivityClearBalanceReason>
{
    private GiftCardActivityClearBalanceReason(string value) : base(value)
    {
    }

    /// <summary>
    /// The seller suspects suspicious activity.
    /// </summary>
    public static readonly GiftCardActivityClearBalanceReason SuspiciousActivity = new("SUSPICIOUS_ACTIVITY");

    /// <summary>
    /// The seller cleared the balance to reuse the gift card.
    /// </summary>
    public static readonly GiftCardActivityClearBalanceReason ReuseGiftcard = new("REUSE_GIFTCARD");

    /// <summary>
    /// The gift card balance was cleared for an unknown reason.
    /// <para>
    /// This reason is read-only and cannot be used to create a <c>CLEAR_BALANCE</c> activity using the Gift Card Activities API.
    /// </para>
    /// </summary>
    public static readonly GiftCardActivityClearBalanceReason UnknownReason = new("UNKNOWN_REASON");

    public static GiftCardActivityClearBalanceReason FromValue(string value) => FromValueCore(value);
}

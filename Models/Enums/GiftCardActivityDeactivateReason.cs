using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the reason for deactivating a <see href="entity:GiftCard">gift card</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GiftCardActivityDeactivateReason>))]
public sealed record GiftCardActivityDeactivateReason : StringEnum<GiftCardActivityDeactivateReason>
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

    public static GiftCardActivityDeactivateReason FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the reason for unblocking a <see href="entity:GiftCard">gift card</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GiftCardActivityUnblockReason>))]
public sealed record GiftCardActivityUnblockReason : StringEnum<GiftCardActivityUnblockReason>
{
    private GiftCardActivityUnblockReason(string value) : base(value)
    {
    }

    /// <summary>
    /// The gift card is unblocked because a chargeback was ruled in favor of the seller.
    /// </summary>
    public static readonly GiftCardActivityUnblockReason ChargebackUnblock = new("CHARGEBACK_UNBLOCK");

    public static GiftCardActivityUnblockReason FromValue(string value) => FromValueCore(value);
}

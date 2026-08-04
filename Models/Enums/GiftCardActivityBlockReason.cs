using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the reason for blocking a <see href="entity:GiftCard">gift card</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GiftCardActivityBlockReason>))]
public sealed record GiftCardActivityBlockReason : StringEnum<GiftCardActivityBlockReason>
{
    private GiftCardActivityBlockReason(string value) : base(value)
    {
    }

    /// <summary>
    /// The gift card is blocked because the buyer initiated a chargeback on the gift card purchase.
    /// </summary>
    public static readonly GiftCardActivityBlockReason ChargebackBlock = new("CHARGEBACK_BLOCK");

    public static GiftCardActivityBlockReason FromValue(string value) => FromValueCore(value);
}

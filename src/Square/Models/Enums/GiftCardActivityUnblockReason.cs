using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the reason for unblocking a <see href="entity:GiftCard">gift card</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GiftCardActivityUnblockReason>))]
public sealed record GiftCardActivityUnblockReason : OpenStringEnum<GiftCardActivityUnblockReason>
{
    private GiftCardActivityUnblockReason(string value) : base(value)
    {
    }

    /// <summary>
    /// The gift card is unblocked because a chargeback was ruled in favor of the seller.
    /// </summary>
    public static readonly GiftCardActivityUnblockReason ChargebackUnblock = new("CHARGEBACK_UNBLOCK");

    public TResult Match<TResult>(Func<TResult> onChargebackUnblock, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ChargebackUnblock => onChargebackUnblock(),
            _ => otherwise(Value)
        };

    public void Match(Action onChargebackUnblock, Action<string> otherwise)
    {
        if (this == ChargebackUnblock) onChargebackUnblock();
        else otherwise(Value);
    }
}

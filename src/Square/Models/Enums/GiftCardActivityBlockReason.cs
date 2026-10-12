using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the reason for blocking a <see href="entity:GiftCard">gift card</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GiftCardActivityBlockReason>))]
public sealed record GiftCardActivityBlockReason : OpenStringEnum<GiftCardActivityBlockReason>
{
    private GiftCardActivityBlockReason(string value) : base(value)
    {
    }

    /// <summary>
    /// The gift card is blocked because the buyer initiated a chargeback on the gift card purchase.
    /// </summary>
    public static readonly GiftCardActivityBlockReason ChargebackBlock = new("CHARGEBACK_BLOCK");

    public TResult Match<TResult>(Func<TResult> onChargebackBlock, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ChargebackBlock => onChargebackBlock(),
            _ => otherwise(Value)
        };

    public void Match(Action onChargebackBlock, Action<string> otherwise)
    {
        if (this == ChargebackBlock) onChargebackBlock();
        else otherwise(Value);
    }
}

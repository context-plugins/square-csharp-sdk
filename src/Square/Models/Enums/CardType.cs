using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates a card's type, such as <c>CREDIT</c> or <c>DEBIT</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CardType>))]
public sealed record CardType : OpenStringEnum<CardType>
{
    private CardType(string value) : base(value)
    {
    }

    public static readonly CardType UnknownCardType = new("UNKNOWN_CARD_TYPE");

    public static readonly CardType Credit = new("CREDIT");

    public static readonly CardType Debit = new("DEBIT");

    public TResult Match<TResult>(Func<TResult> onUnknownCardType,
        Func<TResult> onCredit,
        Func<TResult> onDebit,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == UnknownCardType => onUnknownCardType(),
            _ when this == Credit => onCredit(),
            _ when this == Debit => onDebit(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknownCardType, Action onCredit, Action onDebit, Action<string> otherwise)
    {
        if (this == UnknownCardType) onUnknownCardType();
        else if (this == Credit) onCredit();
        else if (this == Debit) onDebit();
        else otherwise(Value);
    }
}

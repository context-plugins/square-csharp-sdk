using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the brand for a co-branded card.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CardCoBrand>))]
public sealed record CardCoBrand : OpenStringEnum<CardCoBrand>
{
    private CardCoBrand(string value) : base(value)
    {
    }

    public static readonly CardCoBrand Unknown = new("UNKNOWN");

    public static readonly CardCoBrand Afterpay = new("AFTERPAY");

    public static readonly CardCoBrand Clearpay = new("CLEARPAY");

    public TResult Match<TResult>(Func<TResult> onUnknown,
        Func<TResult> onAfterpay,
        Func<TResult> onClearpay,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unknown => onUnknown(),
            _ when this == Afterpay => onAfterpay(),
            _ when this == Clearpay => onClearpay(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknown, Action onAfterpay, Action onClearpay, Action<string> otherwise)
    {
        if (this == Unknown) onUnknown();
        else if (this == Afterpay) onAfterpay();
        else if (this == Clearpay) onClearpay();
        else otherwise(Value);
    }
}

using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates a card's prepaid type, such as <c>NOT_PREPAID</c> or <c>PREPAID</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CardPrepaidType>))]
public sealed record CardPrepaidType : OpenStringEnum<CardPrepaidType>
{
    private CardPrepaidType(string value) : base(value)
    {
    }

    public static readonly CardPrepaidType UnknownPrepaidType = new("UNKNOWN_PREPAID_TYPE");

    public static readonly CardPrepaidType NotPrepaid = new("NOT_PREPAID");

    public static readonly CardPrepaidType Prepaid = new("PREPAID");

    public TResult Match<TResult>(Func<TResult> onUnknownPrepaidType,
        Func<TResult> onNotPrepaid,
        Func<TResult> onPrepaid,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == UnknownPrepaidType => onUnknownPrepaidType(),
            _ when this == NotPrepaid => onNotPrepaid(),
            _ when this == Prepaid => onPrepaid(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknownPrepaidType, Action onNotPrepaid, Action onPrepaid, Action<string> otherwise)
    {
        if (this == UnknownPrepaidType) onUnknownPrepaidType();
        else if (this == NotPrepaid) onNotPrepaid();
        else if (this == Prepaid) onPrepaid();
        else otherwise(Value);
    }
}

using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1TenderEntryMethod>))]
public sealed record V1TenderEntryMethod : OpenStringEnum<V1TenderEntryMethod>
{
    private V1TenderEntryMethod(string value) : base(value)
    {
    }

    public static readonly V1TenderEntryMethod Manual = new("MANUAL");

    public static readonly V1TenderEntryMethod Scanned = new("SCANNED");

    public static readonly V1TenderEntryMethod SquareCash = new("SQUARE_CASH");

    public static readonly V1TenderEntryMethod SquareWallet = new("SQUARE_WALLET");

    public static readonly V1TenderEntryMethod Swiped = new("SWIPED");

    public static readonly V1TenderEntryMethod WebForm = new("WEB_FORM");

    public static readonly V1TenderEntryMethod Other = new("OTHER");

    public TResult Match<TResult>(Func<TResult> onManual,
        Func<TResult> onScanned,
        Func<TResult> onSquareCash,
        Func<TResult> onSquareWallet,
        Func<TResult> onSwiped,
        Func<TResult> onWebForm,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Manual => onManual(),
            _ when this == Scanned => onScanned(),
            _ when this == SquareCash => onSquareCash(),
            _ when this == SquareWallet => onSquareWallet(),
            _ when this == Swiped => onSwiped(),
            _ when this == WebForm => onWebForm(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onManual,
        Action onScanned,
        Action onSquareCash,
        Action onSquareWallet,
        Action onSwiped,
        Action onWebForm,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == Manual) onManual();
        else if (this == Scanned) onScanned();
        else if (this == SquareCash) onSquareCash();
        else if (this == SquareWallet) onSquareWallet();
        else if (this == Swiped) onSwiped();
        else if (this == WebForm) onWebForm();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}

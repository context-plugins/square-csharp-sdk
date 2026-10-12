using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1TenderType>))]
public sealed record V1TenderType : OpenStringEnum<V1TenderType>
{
    private V1TenderType(string value) : base(value)
    {
    }

    public static readonly V1TenderType CreditCard = new("CREDIT_CARD");

    public static readonly V1TenderType Cash = new("CASH");

    public static readonly V1TenderType ThirdPartyCard = new("THIRD_PARTY_CARD");

    public static readonly V1TenderType NoSale = new("NO_SALE");

    public static readonly V1TenderType SquareWallet = new("SQUARE_WALLET");

    public static readonly V1TenderType SquareGiftCard = new("SQUARE_GIFT_CARD");

    public static readonly V1TenderType Unknown = new("UNKNOWN");

    public static readonly V1TenderType Other = new("OTHER");

    public TResult Match<TResult>(Func<TResult> onCreditCard,
        Func<TResult> onCash,
        Func<TResult> onThirdPartyCard,
        Func<TResult> onNoSale,
        Func<TResult> onSquareWallet,
        Func<TResult> onSquareGiftCard,
        Func<TResult> onUnknown,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CreditCard => onCreditCard(),
            _ when this == Cash => onCash(),
            _ when this == ThirdPartyCard => onThirdPartyCard(),
            _ when this == NoSale => onNoSale(),
            _ when this == SquareWallet => onSquareWallet(),
            _ when this == SquareGiftCard => onSquareGiftCard(),
            _ when this == Unknown => onUnknown(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreditCard,
        Action onCash,
        Action onThirdPartyCard,
        Action onNoSale,
        Action onSquareWallet,
        Action onSquareGiftCard,
        Action onUnknown,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == CreditCard) onCreditCard();
        else if (this == Cash) onCash();
        else if (this == ThirdPartyCard) onThirdPartyCard();
        else if (this == NoSale) onNoSale();
        else if (this == SquareWallet) onSquareWallet();
        else if (this == SquareGiftCard) onSquareGiftCard();
        else if (this == Unknown) onUnknown();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}

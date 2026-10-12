using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates a tender's type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TenderType>))]
public sealed record TenderType : OpenStringEnum<TenderType>
{
    private TenderType(string value) : base(value)
    {
    }

    /// <summary>
    /// A credit card.
    /// </summary>
    public static readonly TenderType Card = new("CARD");

    /// <summary>
    /// Cash.
    /// </summary>
    public static readonly TenderType Cash = new("CASH");

    /// <summary>
    /// A credit card processed with a card processor other than Square.
    /// <para>
    /// This value applies only to merchants in countries where Square does not
    /// yet provide card processing.
    /// </para>
    /// </summary>
    public static readonly TenderType ThirdPartyCard = new("THIRD_PARTY_CARD");

    /// <summary>
    /// A Square gift card.
    /// </summary>
    public static readonly TenderType SquareGiftCard = new("SQUARE_GIFT_CARD");

    /// <summary>
    /// This tender represents the register being opened for a "no sale" event.
    /// </summary>
    public static readonly TenderType NoSale = new("NO_SALE");

    /// <summary>
    /// A bank account payment.
    /// </summary>
    public static readonly TenderType BankAccount = new("BANK_ACCOUNT");

    /// <summary>
    /// A payment from a digital wallet, e.g. Cash App, Paypay, Rakuten Pay,
    /// Au Pay, D Barai, Merpay, Wechat Pay, Alipay.
    /// <para>
    /// Note: Some "digital wallets", including Google Pay and Apple Pay, facilitate
    /// card payments.  Those payments have the <c>CARD</c> type.
    /// </para>
    /// </summary>
    public static readonly TenderType Wallet = new("WALLET");

    /// <summary>
    /// A Buy Now Pay Later payment.
    /// </summary>
    public static readonly TenderType BuyNowPayLater = new("BUY_NOW_PAY_LATER");

    /// <summary>
    /// A Square House Account payment.
    /// </summary>
    public static readonly TenderType SquareAccount = new("SQUARE_ACCOUNT");

    /// <summary>
    /// A form of tender that does not match any other value.
    /// </summary>
    public static readonly TenderType Other = new("OTHER");

    public TResult Match<TResult>(Func<TResult> onCard,
        Func<TResult> onCash,
        Func<TResult> onThirdPartyCard,
        Func<TResult> onSquareGiftCard,
        Func<TResult> onNoSale,
        Func<TResult> onBankAccount,
        Func<TResult> onWallet,
        Func<TResult> onBuyNowPayLater,
        Func<TResult> onSquareAccount,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Card => onCard(),
            _ when this == Cash => onCash(),
            _ when this == ThirdPartyCard => onThirdPartyCard(),
            _ when this == SquareGiftCard => onSquareGiftCard(),
            _ when this == NoSale => onNoSale(),
            _ when this == BankAccount => onBankAccount(),
            _ when this == Wallet => onWallet(),
            _ when this == BuyNowPayLater => onBuyNowPayLater(),
            _ when this == SquareAccount => onSquareAccount(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onCard,
        Action onCash,
        Action onThirdPartyCard,
        Action onSquareGiftCard,
        Action onNoSale,
        Action onBankAccount,
        Action onWallet,
        Action onBuyNowPayLater,
        Action onSquareAccount,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == Card) onCard();
        else if (this == Cash) onCash();
        else if (this == ThirdPartyCard) onThirdPartyCard();
        else if (this == SquareGiftCard) onSquareGiftCard();
        else if (this == NoSale) onNoSale();
        else if (this == BankAccount) onBankAccount();
        else if (this == Wallet) onWallet();
        else if (this == BuyNowPayLater) onBuyNowPayLater();
        else if (this == SquareAccount) onSquareAccount();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}

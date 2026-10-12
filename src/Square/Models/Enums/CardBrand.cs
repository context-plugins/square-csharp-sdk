using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates a card's brand, such as <c>VISA</c> or <c>MASTERCARD</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CardBrand>))]
public sealed record CardBrand : OpenStringEnum<CardBrand>
{
    private CardBrand(string value) : base(value)
    {
    }

    public static readonly CardBrand OtherBrand = new("OTHER_BRAND");

    public static readonly CardBrand Visa = new("VISA");

    public static readonly CardBrand Mastercard = new("MASTERCARD");

    public static readonly CardBrand AmericanExpress = new("AMERICAN_EXPRESS");

    public static readonly CardBrand Discover = new("DISCOVER");

    public static readonly CardBrand DiscoverDiners = new("DISCOVER_DINERS");

    public static readonly CardBrand Jcb = new("JCB");

    public static readonly CardBrand ChinaUnionpay = new("CHINA_UNIONPAY");

    public static readonly CardBrand SquareGiftCard = new("SQUARE_GIFT_CARD");

    public static readonly CardBrand SquareCapitalCard = new("SQUARE_CAPITAL_CARD");

    public static readonly CardBrand Interac = new("INTERAC");

    public static readonly CardBrand Eftpos = new("EFTPOS");

    public static readonly CardBrand Felica = new("FELICA");

    public static readonly CardBrand Ebt = new("EBT");

    public TResult Match<TResult>(Func<TResult> onOtherBrand,
        Func<TResult> onVisa,
        Func<TResult> onMastercard,
        Func<TResult> onAmericanExpress,
        Func<TResult> onDiscover,
        Func<TResult> onDiscoverDiners,
        Func<TResult> onJcb,
        Func<TResult> onChinaUnionpay,
        Func<TResult> onSquareGiftCard,
        Func<TResult> onSquareCapitalCard,
        Func<TResult> onInterac,
        Func<TResult> onEftpos,
        Func<TResult> onFelica,
        Func<TResult> onEbt,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == OtherBrand => onOtherBrand(),
            _ when this == Visa => onVisa(),
            _ when this == Mastercard => onMastercard(),
            _ when this == AmericanExpress => onAmericanExpress(),
            _ when this == Discover => onDiscover(),
            _ when this == DiscoverDiners => onDiscoverDiners(),
            _ when this == Jcb => onJcb(),
            _ when this == ChinaUnionpay => onChinaUnionpay(),
            _ when this == SquareGiftCard => onSquareGiftCard(),
            _ when this == SquareCapitalCard => onSquareCapitalCard(),
            _ when this == Interac => onInterac(),
            _ when this == Eftpos => onEftpos(),
            _ when this == Felica => onFelica(),
            _ when this == Ebt => onEbt(),
            _ => otherwise(Value)
        };

    public void Match(Action onOtherBrand,
        Action onVisa,
        Action onMastercard,
        Action onAmericanExpress,
        Action onDiscover,
        Action onDiscoverDiners,
        Action onJcb,
        Action onChinaUnionpay,
        Action onSquareGiftCard,
        Action onSquareCapitalCard,
        Action onInterac,
        Action onEftpos,
        Action onFelica,
        Action onEbt,
        Action<string> otherwise)
    {
        if (this == OtherBrand) onOtherBrand();
        else if (this == Visa) onVisa();
        else if (this == Mastercard) onMastercard();
        else if (this == AmericanExpress) onAmericanExpress();
        else if (this == Discover) onDiscover();
        else if (this == DiscoverDiners) onDiscoverDiners();
        else if (this == Jcb) onJcb();
        else if (this == ChinaUnionpay) onChinaUnionpay();
        else if (this == SquareGiftCard) onSquareGiftCard();
        else if (this == SquareCapitalCard) onSquareCapitalCard();
        else if (this == Interac) onInterac();
        else if (this == Eftpos) onEftpos();
        else if (this == Felica) onFelica();
        else if (this == Ebt) onEbt();
        else otherwise(Value);
    }
}

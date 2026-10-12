using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The brand of a credit card.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1TenderCardBrand>))]
public sealed record V1TenderCardBrand : OpenStringEnum<V1TenderCardBrand>
{
    private V1TenderCardBrand(string value) : base(value)
    {
    }

    public static readonly V1TenderCardBrand OtherBrand = new("OTHER_BRAND");

    public static readonly V1TenderCardBrand Visa = new("VISA");

    public static readonly V1TenderCardBrand MasterCard = new("MASTER_CARD");

    public static readonly V1TenderCardBrand AmericanExpress = new("AMERICAN_EXPRESS");

    public static readonly V1TenderCardBrand Discover = new("DISCOVER");

    public static readonly V1TenderCardBrand DiscoverDiners = new("DISCOVER_DINERS");

    public static readonly V1TenderCardBrand Jcb = new("JCB");

    public static readonly V1TenderCardBrand ChinaUnionpay = new("CHINA_UNIONPAY");

    public static readonly V1TenderCardBrand SquareGiftCard = new("SQUARE_GIFT_CARD");

    public TResult Match<TResult>(Func<TResult> onOtherBrand,
        Func<TResult> onVisa,
        Func<TResult> onMasterCard,
        Func<TResult> onAmericanExpress,
        Func<TResult> onDiscover,
        Func<TResult> onDiscoverDiners,
        Func<TResult> onJcb,
        Func<TResult> onChinaUnionpay,
        Func<TResult> onSquareGiftCard,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == OtherBrand => onOtherBrand(),
            _ when this == Visa => onVisa(),
            _ when this == MasterCard => onMasterCard(),
            _ when this == AmericanExpress => onAmericanExpress(),
            _ when this == Discover => onDiscover(),
            _ when this == DiscoverDiners => onDiscoverDiners(),
            _ when this == Jcb => onJcb(),
            _ when this == ChinaUnionpay => onChinaUnionpay(),
            _ when this == SquareGiftCard => onSquareGiftCard(),
            _ => otherwise(Value)
        };

    public void Match(Action onOtherBrand,
        Action onVisa,
        Action onMasterCard,
        Action onAmericanExpress,
        Action onDiscover,
        Action onDiscoverDiners,
        Action onJcb,
        Action onChinaUnionpay,
        Action onSquareGiftCard,
        Action<string> otherwise)
    {
        if (this == OtherBrand) onOtherBrand();
        else if (this == Visa) onVisa();
        else if (this == MasterCard) onMasterCard();
        else if (this == AmericanExpress) onAmericanExpress();
        else if (this == Discover) onDiscover();
        else if (this == DiscoverDiners) onDiscoverDiners();
        else if (this == Jcb) onJcb();
        else if (this == ChinaUnionpay) onChinaUnionpay();
        else if (this == SquareGiftCard) onSquareGiftCard();
        else otherwise(Value);
    }
}

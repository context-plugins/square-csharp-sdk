using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TenderBuyNowPayLaterDetailsBrand>))]
public sealed record TenderBuyNowPayLaterDetailsBrand : OpenStringEnum<TenderBuyNowPayLaterDetailsBrand>
{
    private TenderBuyNowPayLaterDetailsBrand(string value) : base(value)
    {
    }

    public static readonly TenderBuyNowPayLaterDetailsBrand OtherBrand = new("OTHER_BRAND");

    public static readonly TenderBuyNowPayLaterDetailsBrand Afterpay = new("AFTERPAY");

    public TResult Match<TResult>(Func<TResult> onOtherBrand,
        Func<TResult> onAfterpay,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == OtherBrand => onOtherBrand(),
            _ when this == Afterpay => onAfterpay(),
            _ => otherwise(Value)
        };

    public void Match(Action onOtherBrand, Action onAfterpay, Action<string> otherwise)
    {
        if (this == OtherBrand) onOtherBrand();
        else if (this == Afterpay) onAfterpay();
        else otherwise(Value);
    }
}

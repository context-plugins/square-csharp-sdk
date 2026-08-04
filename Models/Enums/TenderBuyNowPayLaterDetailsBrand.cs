using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TenderBuyNowPayLaterDetailsBrand>))]
public sealed record TenderBuyNowPayLaterDetailsBrand : StringEnum<TenderBuyNowPayLaterDetailsBrand>
{
    private TenderBuyNowPayLaterDetailsBrand(string value) : base(value)
    {
    }

    public static readonly TenderBuyNowPayLaterDetailsBrand OtherBrand = new("OTHER_BRAND");

    public static readonly TenderBuyNowPayLaterDetailsBrand Afterpay = new("AFTERPAY");

    public static TenderBuyNowPayLaterDetailsBrand FromValue(string value) => FromValueCore(value);
}

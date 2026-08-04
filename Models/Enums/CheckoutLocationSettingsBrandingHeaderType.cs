using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<CheckoutLocationSettingsBrandingHeaderType>))]
public sealed record CheckoutLocationSettingsBrandingHeaderType : StringEnum<CheckoutLocationSettingsBrandingHeaderType>
{
    private CheckoutLocationSettingsBrandingHeaderType(string value) : base(value)
    {
    }

    public static readonly CheckoutLocationSettingsBrandingHeaderType BusinessName = new("BUSINESS_NAME");

    public static readonly CheckoutLocationSettingsBrandingHeaderType FramedLogo = new("FRAMED_LOGO");

    public static readonly CheckoutLocationSettingsBrandingHeaderType FullWidthLogo = new("FULL_WIDTH_LOGO");

    public static CheckoutLocationSettingsBrandingHeaderType FromValue(string value) => FromValueCore(value);
}

using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<CheckoutLocationSettingsBrandingHeaderType>))]
public sealed record CheckoutLocationSettingsBrandingHeaderType : OpenStringEnum<CheckoutLocationSettingsBrandingHeaderType>
{
    private CheckoutLocationSettingsBrandingHeaderType(string value) : base(value)
    {
    }

    public static readonly CheckoutLocationSettingsBrandingHeaderType BusinessName = new("BUSINESS_NAME");

    public static readonly CheckoutLocationSettingsBrandingHeaderType FramedLogo = new("FRAMED_LOGO");

    public static readonly CheckoutLocationSettingsBrandingHeaderType FullWidthLogo = new("FULL_WIDTH_LOGO");

    public TResult Match<TResult>(Func<TResult> onBusinessName,
        Func<TResult> onFramedLogo,
        Func<TResult> onFullWidthLogo,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BusinessName => onBusinessName(),
            _ when this == FramedLogo => onFramedLogo(),
            _ when this == FullWidthLogo => onFullWidthLogo(),
            _ => otherwise(Value)
        };

    public void Match(Action onBusinessName, Action onFramedLogo, Action onFullWidthLogo, Action<string> otherwise)
    {
        if (this == BusinessName) onBusinessName();
        else if (this == FramedLogo) onFramedLogo();
        else if (this == FullWidthLogo) onFullWidthLogo();
        else otherwise(Value);
    }
}

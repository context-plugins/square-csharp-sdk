using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<CheckoutLocationSettingsBrandingButtonShape>))]
public sealed record CheckoutLocationSettingsBrandingButtonShape : StringEnum<CheckoutLocationSettingsBrandingButtonShape>
{
    private CheckoutLocationSettingsBrandingButtonShape(string value) : base(value)
    {
    }

    public static readonly CheckoutLocationSettingsBrandingButtonShape Squared = new("SQUARED");

    public static readonly CheckoutLocationSettingsBrandingButtonShape Rounded = new("ROUNDED");

    public static readonly CheckoutLocationSettingsBrandingButtonShape Pill = new("PILL");

    public static CheckoutLocationSettingsBrandingButtonShape FromValue(string value) => FromValueCore(value);
}

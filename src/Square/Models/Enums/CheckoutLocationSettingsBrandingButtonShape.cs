using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<CheckoutLocationSettingsBrandingButtonShape>))]
public sealed record CheckoutLocationSettingsBrandingButtonShape : OpenStringEnum<CheckoutLocationSettingsBrandingButtonShape>
{
    private CheckoutLocationSettingsBrandingButtonShape(string value) : base(value)
    {
    }

    public static readonly CheckoutLocationSettingsBrandingButtonShape Squared = new("SQUARED");

    public static readonly CheckoutLocationSettingsBrandingButtonShape Rounded = new("ROUNDED");

    public static readonly CheckoutLocationSettingsBrandingButtonShape Pill = new("PILL");

    public TResult Match<TResult>(Func<TResult> onSquared,
        Func<TResult> onRounded,
        Func<TResult> onPill,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Squared => onSquared(),
            _ when this == Rounded => onRounded(),
            _ when this == Pill => onPill(),
            _ => otherwise(Value)
        };

    public void Match(Action onSquared, Action onRounded, Action onPill, Action<string> otherwise)
    {
        if (this == Squared) onSquared();
        else if (this == Rounded) onRounded();
        else if (this == Pill) onPill();
        else otherwise(Value);
    }
}

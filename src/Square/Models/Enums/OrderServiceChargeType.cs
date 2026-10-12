using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<OrderServiceChargeType>))]
public sealed record OrderServiceChargeType : OpenStringEnum<OrderServiceChargeType>
{
    private OrderServiceChargeType(string value) : base(value)
    {
    }

    public static readonly OrderServiceChargeType AutoGratuity = new("AUTO_GRATUITY");

    public static readonly OrderServiceChargeType Custom = new("CUSTOM");

    public TResult Match<TResult>(Func<TResult> onAutoGratuity,
        Func<TResult> onCustom,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AutoGratuity => onAutoGratuity(),
            _ when this == Custom => onCustom(),
            _ => otherwise(Value)
        };

    public void Match(Action onAutoGratuity, Action onCustom, Action<string> otherwise)
    {
        if (this == AutoGratuity) onAutoGratuity();
        else if (this == Custom) onCustom();
        else otherwise(Value);
    }
}

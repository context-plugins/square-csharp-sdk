using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the gift card type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GiftCardType>))]
public sealed record GiftCardType : OpenStringEnum<GiftCardType>
{
    private GiftCardType(string value) : base(value)
    {
    }

    /// <summary>
    /// A plastic gift card.
    /// </summary>
    public static readonly GiftCardType Physical = new("PHYSICAL");

    /// <summary>
    /// A digital gift card.
    /// </summary>
    public static readonly GiftCardType Digital = new("DIGITAL");

    public TResult Match<TResult>(Func<TResult> onPhysical, Func<TResult> onDigital, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Physical => onPhysical(),
            _ when this == Digital => onDigital(),
            _ => otherwise(Value)
        };

    public void Match(Action onPhysical, Action onDigital, Action<string> otherwise)
    {
        if (this == Physical) onPhysical();
        else if (this == Digital) onDigital();
        else otherwise(Value);
    }
}

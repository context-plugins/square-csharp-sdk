using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Determines the pricing of a <see href="entity:Subscription">Subscription</see>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SubscriptionPricingType>))]
public sealed record SubscriptionPricingType : OpenStringEnum<SubscriptionPricingType>
{
    private SubscriptionPricingType(string value) : base(value)
    {
    }

    /// <summary>
    /// Static pricing
    /// </summary>
    public static readonly SubscriptionPricingType Static = new("STATIC");

    /// <summary>
    /// Relative pricing
    /// </summary>
    public static readonly SubscriptionPricingType Relative = new("RELATIVE");

    public TResult Match<TResult>(Func<TResult> onStatic, Func<TResult> onRelative, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Static => onStatic(),
            _ when this == Relative => onRelative(),
            _ => otherwise(Value)
        };

    public void Match(Action onStatic, Action onRelative, Action<string> otherwise)
    {
        if (this == Static) onStatic();
        else if (this == Relative) onRelative();
        else otherwise(Value);
    }
}

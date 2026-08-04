using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Determines the pricing of a <see href="entity:Subscription">Subscription</see>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SubscriptionPricingType>))]
public sealed record SubscriptionPricingType : StringEnum<SubscriptionPricingType>
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

    public static SubscriptionPricingType FromValue(string value) => FromValueCore(value);
}

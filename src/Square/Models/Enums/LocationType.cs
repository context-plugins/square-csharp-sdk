using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// A location's type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LocationType>))]
public sealed record LocationType : OpenStringEnum<LocationType>
{
    private LocationType(string value) : base(value)
    {
    }

    /// <summary>
    /// A place of business with a physical location.
    /// </summary>
    public static readonly LocationType Physical = new("PHYSICAL");

    /// <summary>
    /// A place of business that is mobile, such as a food truck or online store.
    /// </summary>
    public static readonly LocationType Mobile = new("MOBILE");

    public TResult Match<TResult>(Func<TResult> onPhysical, Func<TResult> onMobile, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Physical => onPhysical(),
            _ when this == Mobile => onMobile(),
            _ => otherwise(Value)
        };

    public void Match(Action onPhysical, Action onMobile, Action<string> otherwise)
    {
        if (this == Physical) onPhysical();
        else if (this == Mobile) onMobile();
        else otherwise(Value);
    }
}

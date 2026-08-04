using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// A location's type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LocationType>))]
public sealed record LocationType : StringEnum<LocationType>
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

    public static LocationType FromValue(string value) => FromValueCore(value);
}

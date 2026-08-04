using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// A location's status.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LocationStatus>))]
public sealed record LocationStatus : StringEnum<LocationStatus>
{
    private LocationStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// A location that is active for business.
    /// </summary>
    public static readonly LocationStatus Active = new("ACTIVE");

    /// <summary>
    /// A location that is not active for business. Inactive locations provide historical
    /// information. Hide inactive locations unless the user has requested to see them.
    /// </summary>
    public static readonly LocationStatus Inactive = new("INACTIVE");

    public static LocationStatus FromValue(string value) => FromValueCore(value);
}

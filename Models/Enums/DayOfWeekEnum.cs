using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the specific day  of the week.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DayOfWeekEnum>))]
public sealed record DayOfWeekEnum : StringEnum<DayOfWeekEnum>
{
    private DayOfWeekEnum(string value) : base(value)
    {
    }

    /// <summary>
    /// Sunday
    /// </summary>
    public static readonly DayOfWeekEnum Sun = new("SUN");

    /// <summary>
    /// Monday
    /// </summary>
    public static readonly DayOfWeekEnum Mon = new("MON");

    /// <summary>
    /// Tuesday
    /// </summary>
    public static readonly DayOfWeekEnum Tue = new("TUE");

    /// <summary>
    /// Wednesday
    /// </summary>
    public static readonly DayOfWeekEnum Wed = new("WED");

    /// <summary>
    /// Thursday
    /// </summary>
    public static readonly DayOfWeekEnum Thu = new("THU");

    /// <summary>
    /// Friday
    /// </summary>
    public static readonly DayOfWeekEnum Fri = new("FRI");

    /// <summary>
    /// Saturday
    /// </summary>
    public static readonly DayOfWeekEnum Sat = new("SAT");

    public static DayOfWeekEnum FromValue(string value) => FromValueCore(value);
}

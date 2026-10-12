using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the specific day  of the week.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DayOfWeekEnum>))]
public sealed record DayOfWeekEnum : OpenStringEnum<DayOfWeekEnum>
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

    public TResult Match<TResult>(Func<TResult> onSun,
        Func<TResult> onMon,
        Func<TResult> onTue,
        Func<TResult> onWed,
        Func<TResult> onThu,
        Func<TResult> onFri,
        Func<TResult> onSat,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Sun => onSun(),
            _ when this == Mon => onMon(),
            _ when this == Tue => onTue(),
            _ when this == Wed => onWed(),
            _ when this == Thu => onThu(),
            _ when this == Fri => onFri(),
            _ when this == Sat => onSat(),
            _ => otherwise(Value)
        };

    public void Match(Action onSun,
        Action onMon,
        Action onTue,
        Action onWed,
        Action onThu,
        Action onFri,
        Action onSat,
        Action<string> otherwise)
    {
        if (this == Sun) onSun();
        else if (this == Mon) onMon();
        else if (this == Tue) onTue();
        else if (this == Wed) onWed();
        else if (this == Thu) onThu();
        else if (this == Fri) onFri();
        else if (this == Sat) onSat();
        else otherwise(Value);
    }
}

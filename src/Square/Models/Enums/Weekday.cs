using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The days of the week.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Weekday>))]
public sealed record Weekday : OpenStringEnum<Weekday>
{
    private Weekday(string value) : base(value)
    {
    }

    /// <summary>
    /// Monday
    /// </summary>
    public static readonly Weekday Mon = new("MON");

    /// <summary>
    /// Tuesday
    /// </summary>
    public static readonly Weekday Tue = new("TUE");

    /// <summary>
    /// Wednesday
    /// </summary>
    public static readonly Weekday Wed = new("WED");

    /// <summary>
    /// Thursday
    /// </summary>
    public static readonly Weekday Thu = new("THU");

    /// <summary>
    /// Friday
    /// </summary>
    public static readonly Weekday Fri = new("FRI");

    /// <summary>
    /// Saturday
    /// </summary>
    public static readonly Weekday Sat = new("SAT");

    /// <summary>
    /// Sunday
    /// </summary>
    public static readonly Weekday Sun = new("SUN");

    public TResult Match<TResult>(Func<TResult> onMon,
        Func<TResult> onTue,
        Func<TResult> onWed,
        Func<TResult> onThu,
        Func<TResult> onFri,
        Func<TResult> onSat,
        Func<TResult> onSun,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Mon => onMon(),
            _ when this == Tue => onTue(),
            _ when this == Wed => onWed(),
            _ when this == Thu => onThu(),
            _ when this == Fri => onFri(),
            _ when this == Sat => onSat(),
            _ when this == Sun => onSun(),
            _ => otherwise(Value)
        };

    public void Match(Action onMon,
        Action onTue,
        Action onWed,
        Action onThu,
        Action onFri,
        Action onSat,
        Action onSun,
        Action<string> otherwise)
    {
        if (this == Mon) onMon();
        else if (this == Tue) onTue();
        else if (this == Wed) onWed();
        else if (this == Thu) onThu();
        else if (this == Fri) onFri();
        else if (this == Sat) onSat();
        else if (this == Sun) onSun();
        else otherwise(Value);
    }
}

using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Unit of time used to measure a quantity (a duration).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MeasurementUnitTime>))]
public sealed record MeasurementUnitTime : OpenStringEnum<MeasurementUnitTime>
{
    private MeasurementUnitTime(string value) : base(value)
    {
    }

    /// <summary>
    /// The time is measured in milliseconds.
    /// </summary>
    public static readonly MeasurementUnitTime GenericMillisecond = new("GENERIC_MILLISECOND");

    /// <summary>
    /// The time is measured in seconds.
    /// </summary>
    public static readonly MeasurementUnitTime GenericSecond = new("GENERIC_SECOND");

    /// <summary>
    /// The time is measured in minutes.
    /// </summary>
    public static readonly MeasurementUnitTime GenericMinute = new("GENERIC_MINUTE");

    /// <summary>
    /// The time is measured in hours.
    /// </summary>
    public static readonly MeasurementUnitTime GenericHour = new("GENERIC_HOUR");

    /// <summary>
    /// The time is measured in days.
    /// </summary>
    public static readonly MeasurementUnitTime GenericDay = new("GENERIC_DAY");

    public TResult Match<TResult>(Func<TResult> onGenericMillisecond,
        Func<TResult> onGenericSecond,
        Func<TResult> onGenericMinute,
        Func<TResult> onGenericHour,
        Func<TResult> onGenericDay,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == GenericMillisecond => onGenericMillisecond(),
            _ when this == GenericSecond => onGenericSecond(),
            _ when this == GenericMinute => onGenericMinute(),
            _ when this == GenericHour => onGenericHour(),
            _ when this == GenericDay => onGenericDay(),
            _ => otherwise(Value)
        };

    public void Match(Action onGenericMillisecond,
        Action onGenericSecond,
        Action onGenericMinute,
        Action onGenericHour,
        Action onGenericDay,
        Action<string> otherwise)
    {
        if (this == GenericMillisecond) onGenericMillisecond();
        else if (this == GenericSecond) onGenericSecond();
        else if (this == GenericMinute) onGenericMinute();
        else if (this == GenericHour) onGenericHour();
        else if (this == GenericDay) onGenericDay();
        else otherwise(Value);
    }
}

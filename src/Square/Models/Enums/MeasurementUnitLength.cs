using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The unit of length used to measure a quantity.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MeasurementUnitLength>))]
public sealed record MeasurementUnitLength : OpenStringEnum<MeasurementUnitLength>
{
    private MeasurementUnitLength(string value) : base(value)
    {
    }

    /// <summary>
    /// The length is measured in inches.
    /// </summary>
    public static readonly MeasurementUnitLength ImperialInch = new("IMPERIAL_INCH");

    /// <summary>
    /// The length is measured in feet.
    /// </summary>
    public static readonly MeasurementUnitLength ImperialFoot = new("IMPERIAL_FOOT");

    /// <summary>
    /// The length is measured in yards.
    /// </summary>
    public static readonly MeasurementUnitLength ImperialYard = new("IMPERIAL_YARD");

    /// <summary>
    /// The length is measured in miles.
    /// </summary>
    public static readonly MeasurementUnitLength ImperialMile = new("IMPERIAL_MILE");

    /// <summary>
    /// The length is measured in millimeters.
    /// </summary>
    public static readonly MeasurementUnitLength MetricMillimeter = new("METRIC_MILLIMETER");

    /// <summary>
    /// The length is measured in centimeters.
    /// </summary>
    public static readonly MeasurementUnitLength MetricCentimeter = new("METRIC_CENTIMETER");

    /// <summary>
    /// The length is measured in meters.
    /// </summary>
    public static readonly MeasurementUnitLength MetricMeter = new("METRIC_METER");

    /// <summary>
    /// The length is measured in kilometers.
    /// </summary>
    public static readonly MeasurementUnitLength MetricKilometer = new("METRIC_KILOMETER");

    public TResult Match<TResult>(Func<TResult> onImperialInch,
        Func<TResult> onImperialFoot,
        Func<TResult> onImperialYard,
        Func<TResult> onImperialMile,
        Func<TResult> onMetricMillimeter,
        Func<TResult> onMetricCentimeter,
        Func<TResult> onMetricMeter,
        Func<TResult> onMetricKilometer,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ImperialInch => onImperialInch(),
            _ when this == ImperialFoot => onImperialFoot(),
            _ when this == ImperialYard => onImperialYard(),
            _ when this == ImperialMile => onImperialMile(),
            _ when this == MetricMillimeter => onMetricMillimeter(),
            _ when this == MetricCentimeter => onMetricCentimeter(),
            _ when this == MetricMeter => onMetricMeter(),
            _ when this == MetricKilometer => onMetricKilometer(),
            _ => otherwise(Value)
        };

    public void Match(Action onImperialInch,
        Action onImperialFoot,
        Action onImperialYard,
        Action onImperialMile,
        Action onMetricMillimeter,
        Action onMetricCentimeter,
        Action onMetricMeter,
        Action onMetricKilometer,
        Action<string> otherwise)
    {
        if (this == ImperialInch) onImperialInch();
        else if (this == ImperialFoot) onImperialFoot();
        else if (this == ImperialYard) onImperialYard();
        else if (this == ImperialMile) onImperialMile();
        else if (this == MetricMillimeter) onMetricMillimeter();
        else if (this == MetricCentimeter) onMetricCentimeter();
        else if (this == MetricMeter) onMetricMeter();
        else if (this == MetricKilometer) onMetricKilometer();
        else otherwise(Value);
    }
}

using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Unit of area used to measure a quantity.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MeasurementUnitArea>))]
public sealed record MeasurementUnitArea : OpenStringEnum<MeasurementUnitArea>
{
    private MeasurementUnitArea(string value) : base(value)
    {
    }

    /// <summary>
    /// The area is measured in acres.
    /// </summary>
    public static readonly MeasurementUnitArea ImperialAcre = new("IMPERIAL_ACRE");

    /// <summary>
    /// The area is measured in square inches.
    /// </summary>
    public static readonly MeasurementUnitArea ImperialSquareInch = new("IMPERIAL_SQUARE_INCH");

    /// <summary>
    /// The area is measured in square feet.
    /// </summary>
    public static readonly MeasurementUnitArea ImperialSquareFoot = new("IMPERIAL_SQUARE_FOOT");

    /// <summary>
    /// The area is measured in square yards.
    /// </summary>
    public static readonly MeasurementUnitArea ImperialSquareYard = new("IMPERIAL_SQUARE_YARD");

    /// <summary>
    /// The area is measured in square miles.
    /// </summary>
    public static readonly MeasurementUnitArea ImperialSquareMile = new("IMPERIAL_SQUARE_MILE");

    /// <summary>
    /// The area is measured in square centimeters.
    /// </summary>
    public static readonly MeasurementUnitArea MetricSquareCentimeter = new("METRIC_SQUARE_CENTIMETER");

    /// <summary>
    /// The area is measured in square meters.
    /// </summary>
    public static readonly MeasurementUnitArea MetricSquareMeter = new("METRIC_SQUARE_METER");

    /// <summary>
    /// The area is measured in square kilometers.
    /// </summary>
    public static readonly MeasurementUnitArea MetricSquareKilometer = new("METRIC_SQUARE_KILOMETER");

    public TResult Match<TResult>(Func<TResult> onImperialAcre,
        Func<TResult> onImperialSquareInch,
        Func<TResult> onImperialSquareFoot,
        Func<TResult> onImperialSquareYard,
        Func<TResult> onImperialSquareMile,
        Func<TResult> onMetricSquareCentimeter,
        Func<TResult> onMetricSquareMeter,
        Func<TResult> onMetricSquareKilometer,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ImperialAcre => onImperialAcre(),
            _ when this == ImperialSquareInch => onImperialSquareInch(),
            _ when this == ImperialSquareFoot => onImperialSquareFoot(),
            _ when this == ImperialSquareYard => onImperialSquareYard(),
            _ when this == ImperialSquareMile => onImperialSquareMile(),
            _ when this == MetricSquareCentimeter => onMetricSquareCentimeter(),
            _ when this == MetricSquareMeter => onMetricSquareMeter(),
            _ when this == MetricSquareKilometer => onMetricSquareKilometer(),
            _ => otherwise(Value)
        };

    public void Match(Action onImperialAcre,
        Action onImperialSquareInch,
        Action onImperialSquareFoot,
        Action onImperialSquareYard,
        Action onImperialSquareMile,
        Action onMetricSquareCentimeter,
        Action onMetricSquareMeter,
        Action onMetricSquareKilometer,
        Action<string> otherwise)
    {
        if (this == ImperialAcre) onImperialAcre();
        else if (this == ImperialSquareInch) onImperialSquareInch();
        else if (this == ImperialSquareFoot) onImperialSquareFoot();
        else if (this == ImperialSquareYard) onImperialSquareYard();
        else if (this == ImperialSquareMile) onImperialSquareMile();
        else if (this == MetricSquareCentimeter) onMetricSquareCentimeter();
        else if (this == MetricSquareMeter) onMetricSquareMeter();
        else if (this == MetricSquareKilometer) onMetricSquareKilometer();
        else otherwise(Value);
    }
}

using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Unit of weight used to measure a quantity.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MeasurementUnitWeight>))]
public sealed record MeasurementUnitWeight : OpenStringEnum<MeasurementUnitWeight>
{
    private MeasurementUnitWeight(string value) : base(value)
    {
    }

    /// <summary>
    /// The weight is measured in ounces.
    /// </summary>
    public static readonly MeasurementUnitWeight ImperialWeightOunce = new("IMPERIAL_WEIGHT_OUNCE");

    /// <summary>
    /// The weight is measured in pounds.
    /// </summary>
    public static readonly MeasurementUnitWeight ImperialPound = new("IMPERIAL_POUND");

    /// <summary>
    /// The weight is measured in stones.
    /// </summary>
    public static readonly MeasurementUnitWeight ImperialStone = new("IMPERIAL_STONE");

    /// <summary>
    /// The weight is measured in milligrams.
    /// </summary>
    public static readonly MeasurementUnitWeight MetricMilligram = new("METRIC_MILLIGRAM");

    /// <summary>
    /// The weight is measured in grams.
    /// </summary>
    public static readonly MeasurementUnitWeight MetricGram = new("METRIC_GRAM");

    /// <summary>
    /// The weight is measured in kilograms.
    /// </summary>
    public static readonly MeasurementUnitWeight MetricKilogram = new("METRIC_KILOGRAM");

    public TResult Match<TResult>(Func<TResult> onImperialWeightOunce,
        Func<TResult> onImperialPound,
        Func<TResult> onImperialStone,
        Func<TResult> onMetricMilligram,
        Func<TResult> onMetricGram,
        Func<TResult> onMetricKilogram,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ImperialWeightOunce => onImperialWeightOunce(),
            _ when this == ImperialPound => onImperialPound(),
            _ when this == ImperialStone => onImperialStone(),
            _ when this == MetricMilligram => onMetricMilligram(),
            _ when this == MetricGram => onMetricGram(),
            _ when this == MetricKilogram => onMetricKilogram(),
            _ => otherwise(Value)
        };

    public void Match(Action onImperialWeightOunce,
        Action onImperialPound,
        Action onImperialStone,
        Action onMetricMilligram,
        Action onMetricGram,
        Action onMetricKilogram,
        Action<string> otherwise)
    {
        if (this == ImperialWeightOunce) onImperialWeightOunce();
        else if (this == ImperialPound) onImperialPound();
        else if (this == ImperialStone) onImperialStone();
        else if (this == MetricMilligram) onMetricMilligram();
        else if (this == MetricGram) onMetricGram();
        else if (this == MetricKilogram) onMetricKilogram();
        else otherwise(Value);
    }
}

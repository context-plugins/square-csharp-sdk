using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The unit of volume used to measure a quantity.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MeasurementUnitVolume>))]
public sealed record MeasurementUnitVolume : OpenStringEnum<MeasurementUnitVolume>
{
    private MeasurementUnitVolume(string value) : base(value)
    {
    }

    /// <summary>
    /// The volume is measured in ounces.
    /// </summary>
    public static readonly MeasurementUnitVolume GenericFluidOunce = new("GENERIC_FLUID_OUNCE");

    /// <summary>
    /// The volume is measured in shots.
    /// </summary>
    public static readonly MeasurementUnitVolume GenericShot = new("GENERIC_SHOT");

    /// <summary>
    /// The volume is measured in cups.
    /// </summary>
    public static readonly MeasurementUnitVolume GenericCup = new("GENERIC_CUP");

    /// <summary>
    /// The volume is measured in pints.
    /// </summary>
    public static readonly MeasurementUnitVolume GenericPint = new("GENERIC_PINT");

    /// <summary>
    /// The volume is measured in quarts.
    /// </summary>
    public static readonly MeasurementUnitVolume GenericQuart = new("GENERIC_QUART");

    /// <summary>
    /// The volume is measured in gallons.
    /// </summary>
    public static readonly MeasurementUnitVolume GenericGallon = new("GENERIC_GALLON");

    /// <summary>
    /// The volume is measured in cubic inches.
    /// </summary>
    public static readonly MeasurementUnitVolume ImperialCubicInch = new("IMPERIAL_CUBIC_INCH");

    /// <summary>
    /// The volume is measured in cubic feet.
    /// </summary>
    public static readonly MeasurementUnitVolume ImperialCubicFoot = new("IMPERIAL_CUBIC_FOOT");

    /// <summary>
    /// The volume is measured in cubic yards.
    /// </summary>
    public static readonly MeasurementUnitVolume ImperialCubicYard = new("IMPERIAL_CUBIC_YARD");

    /// <summary>
    /// The volume is measured in metric milliliters.
    /// </summary>
    public static readonly MeasurementUnitVolume MetricMilliliter = new("METRIC_MILLILITER");

    /// <summary>
    /// The volume is measured in metric liters.
    /// </summary>
    public static readonly MeasurementUnitVolume MetricLiter = new("METRIC_LITER");

    public TResult Match<TResult>(Func<TResult> onGenericFluidOunce,
        Func<TResult> onGenericShot,
        Func<TResult> onGenericCup,
        Func<TResult> onGenericPint,
        Func<TResult> onGenericQuart,
        Func<TResult> onGenericGallon,
        Func<TResult> onImperialCubicInch,
        Func<TResult> onImperialCubicFoot,
        Func<TResult> onImperialCubicYard,
        Func<TResult> onMetricMilliliter,
        Func<TResult> onMetricLiter,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == GenericFluidOunce => onGenericFluidOunce(),
            _ when this == GenericShot => onGenericShot(),
            _ when this == GenericCup => onGenericCup(),
            _ when this == GenericPint => onGenericPint(),
            _ when this == GenericQuart => onGenericQuart(),
            _ when this == GenericGallon => onGenericGallon(),
            _ when this == ImperialCubicInch => onImperialCubicInch(),
            _ when this == ImperialCubicFoot => onImperialCubicFoot(),
            _ when this == ImperialCubicYard => onImperialCubicYard(),
            _ when this == MetricMilliliter => onMetricMilliliter(),
            _ when this == MetricLiter => onMetricLiter(),
            _ => otherwise(Value)
        };

    public void Match(Action onGenericFluidOunce,
        Action onGenericShot,
        Action onGenericCup,
        Action onGenericPint,
        Action onGenericQuart,
        Action onGenericGallon,
        Action onImperialCubicInch,
        Action onImperialCubicFoot,
        Action onImperialCubicYard,
        Action onMetricMilliliter,
        Action onMetricLiter,
        Action<string> otherwise)
    {
        if (this == GenericFluidOunce) onGenericFluidOunce();
        else if (this == GenericShot) onGenericShot();
        else if (this == GenericCup) onGenericCup();
        else if (this == GenericPint) onGenericPint();
        else if (this == GenericQuart) onGenericQuart();
        else if (this == GenericGallon) onGenericGallon();
        else if (this == ImperialCubicInch) onImperialCubicInch();
        else if (this == ImperialCubicFoot) onImperialCubicFoot();
        else if (this == ImperialCubicYard) onImperialCubicYard();
        else if (this == MetricMilliliter) onMetricMilliliter();
        else if (this == MetricLiter) onMetricLiter();
        else otherwise(Value);
    }
}

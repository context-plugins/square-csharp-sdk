using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Describes the type of this unit and indicates which field contains the unit information. This is an ‘open’ enum.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MeasurementUnitUnitType>))]
public sealed record MeasurementUnitUnitType : OpenStringEnum<MeasurementUnitUnitType>
{
    private MeasurementUnitUnitType(string value) : base(value)
    {
    }

    /// <summary>
    /// The unit details are contained in the custom_unit field.
    /// </summary>
    public static readonly MeasurementUnitUnitType TypeCustom = new("TYPE_CUSTOM");

    /// <summary>
    /// The unit details are contained in the area_unit field.
    /// </summary>
    public static readonly MeasurementUnitUnitType TypeArea = new("TYPE_AREA");

    /// <summary>
    /// The unit details are contained in the length_unit field.
    /// </summary>
    public static readonly MeasurementUnitUnitType TypeLength = new("TYPE_LENGTH");

    /// <summary>
    /// The unit details are contained in the volume_unit field.
    /// </summary>
    public static readonly MeasurementUnitUnitType TypeVolume = new("TYPE_VOLUME");

    /// <summary>
    /// The unit details are contained in the weight_unit field.
    /// </summary>
    public static readonly MeasurementUnitUnitType TypeWeight = new("TYPE_WEIGHT");

    /// <summary>
    /// The unit details are contained in the generic_unit field.
    /// </summary>
    public static readonly MeasurementUnitUnitType TypeGeneric = new("TYPE_GENERIC");

    public TResult Match<TResult>(Func<TResult> onTypeCustom,
        Func<TResult> onTypeArea,
        Func<TResult> onTypeLength,
        Func<TResult> onTypeVolume,
        Func<TResult> onTypeWeight,
        Func<TResult> onTypeGeneric,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == TypeCustom => onTypeCustom(),
            _ when this == TypeArea => onTypeArea(),
            _ when this == TypeLength => onTypeLength(),
            _ when this == TypeVolume => onTypeVolume(),
            _ when this == TypeWeight => onTypeWeight(),
            _ when this == TypeGeneric => onTypeGeneric(),
            _ => otherwise(Value)
        };

    public void Match(Action onTypeCustom,
        Action onTypeArea,
        Action onTypeLength,
        Action onTypeVolume,
        Action onTypeWeight,
        Action onTypeGeneric,
        Action<string> otherwise)
    {
        if (this == TypeCustom) onTypeCustom();
        else if (this == TypeArea) onTypeArea();
        else if (this == TypeLength) onTypeLength();
        else if (this == TypeVolume) onTypeVolume();
        else if (this == TypeWeight) onTypeWeight();
        else if (this == TypeGeneric) onTypeGeneric();
        else otherwise(Value);
    }
}

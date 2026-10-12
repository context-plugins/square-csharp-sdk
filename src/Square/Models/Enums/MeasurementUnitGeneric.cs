using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<MeasurementUnitGeneric>))]
public sealed record MeasurementUnitGeneric : OpenStringEnum<MeasurementUnitGeneric>
{
    private MeasurementUnitGeneric(string value) : base(value)
    {
    }

    /// <summary>
    /// The generic unit.
    /// </summary>
    public static readonly MeasurementUnitGeneric Unit = new("UNIT");

    public TResult Match<TResult>(Func<TResult> onUnit, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unit => onUnit(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnit, Action<string> otherwise)
    {
        if (this == Unit) onUnit();
        else otherwise(Value);
    }
}

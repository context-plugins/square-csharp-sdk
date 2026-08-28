using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a unit of measurement to use with a quantity, such as ounces
/// or inches. Exactly one of the following fields are required: <c>custom_unit</c>,
/// <c>area_unit</c>, <c>length_unit</c>, <c>volume_unit</c>, and <c>weight_unit</c>.
/// </summary>
public record MeasurementUnit
{
    /// <summary>
    /// The information needed to define a custom unit, provided by the seller.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_unit")]
    public MeasurementUnitCustom? CustomUnit { get; init; }

    /// <summary>
    /// Unit of area used to measure a quantity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("area_unit")]
    public MeasurementUnitArea? AreaUnit { get; init; }

    /// <summary>
    /// The unit of length used to measure a quantity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("length_unit")]
    public MeasurementUnitLength? LengthUnit { get; init; }

    /// <summary>
    /// The unit of volume used to measure a quantity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("volume_unit")]
    public MeasurementUnitVolume? VolumeUnit { get; init; }

    /// <summary>
    /// Unit of weight used to measure a quantity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("weight_unit")]
    public MeasurementUnitWeight? WeightUnit { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("generic_unit")]
    public MeasurementUnitGeneric? GenericUnit { get; init; }

    /// <summary>
    /// Unit of time used to measure a quantity (a duration).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time_unit")]
    public MeasurementUnitTime? TimeUnit { get; init; }

    /// <summary>
    /// Describes the type of this unit and indicates which field contains the unit information. This is an ‘open’ enum.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public MeasurementUnitUnitType? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

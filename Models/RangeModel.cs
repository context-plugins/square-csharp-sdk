using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// The range of a number value between the specified lower and upper bounds.
/// </summary>
public record RangeModel
{
    /// <summary>
    /// The lower bound of the number range. At least one of <c>min</c> or <c>max</c> must be specified.
    /// If unspecified, the results will have no minimum value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("min")]
    public string? Min { get; init; }

    /// <summary>
    /// The upper bound of the number range. At least one of <c>min</c> or <c>max</c> must be specified.
    /// If unspecified, the results will have no maximum value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max")]
    public string? Max { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

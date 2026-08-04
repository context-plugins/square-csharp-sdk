using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// A value qualified by unit of measure.
/// </summary>
public record DeviceComponentDetailsMeasurement
{
    /// <summary>
    /// Value of measure.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public int? Value { get; init; }
}

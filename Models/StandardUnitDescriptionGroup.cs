using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Group of standard measurement units.
/// </summary>
public record StandardUnitDescriptionGroup
{
    /// <summary>
    /// List of standard (non-custom) measurement units in this description group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("standard_unit_descriptions")]
    public IReadOnlyList<StandardUnitDescription?>? StandardUnitDescriptions { get; init; }

    /// <summary>
    /// IETF language tag.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("language_code")]
    public string? LanguageCode { get; init; }
}

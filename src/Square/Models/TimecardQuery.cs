using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// The parameters of a <c>Timecard</c> search query, which includes filter and sort options.
/// </summary>
public record TimecardQuery
{
    /// <summary>
    /// Defines a filter used in a search for <c>Timecard</c> records. <c>AND</c> logic is
    /// used by Square's servers to apply each filter property specified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public TimecardFilter? Filter { get; init; }

    /// <summary>
    /// Sets the sort order of search results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort")]
    public TimecardSort? Sort { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

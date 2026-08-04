using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Contains query criteria for the search.
/// </summary>
public record SearchEventsQuery
{
    /// <summary>
    /// Criteria to filter events by.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public SearchEventsFilter? Filter { get; init; }

    /// <summary>
    /// Criteria to sort events by.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort")]
    public SearchEventsSort? Sort { get; init; }
}

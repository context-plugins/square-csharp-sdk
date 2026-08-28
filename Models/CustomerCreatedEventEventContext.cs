using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Information about the change that triggered the event.
/// </summary>
public record CustomerCreatedEventEventContext
{
    /// <summary>
    /// Information about a merge operation, which creates a new customer using aggregated properties from two or more existing customers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merge")]
    public CustomerCreatedEventEventContextMerge? Merge { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

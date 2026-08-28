using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// A request to update a <c>BreakType</c>.
/// </summary>
public record UpdateBreakTypeRequest
{
    /// <summary>
    /// A template for a type of <see href="entity:Break">break</see> that can be added to a
    /// <see href="entity:Timecard">timecard</see>, including the expected duration and paid status.
    /// </summary>
    [JsonPropertyName("break_type")]
    public required BreakType BreakType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// The response to a request to get a <c>BreakType</c>. The response contains
/// the requested <c>BreakType</c> objects and might contain a set of <c>Error</c> objects if
/// the request resulted in errors.
/// </summary>
public record GetBreakTypeResponse
{
    /// <summary>
    /// A template for a type of <see href="entity:Break">break</see> that can be added to a
    /// <see href="entity:Timecard">timecard</see>, including the expected duration and paid status.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("break_type")]
    public BreakType? BreakType { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}

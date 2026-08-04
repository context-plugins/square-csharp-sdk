using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// Searches <see href="entity:Event">Event</see>s for your application.
/// </summary>
public record SearchEventsRequest
{
    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint. Provide this cursor to retrieve the next set of events for your original query.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    [MaxLength(256)]
    public string? Cursor { get; init; }

    /// <summary>
    /// The maximum number of events to return in a single page. The response might contain fewer events. The default value is 100, which is also the maximum allowed value.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </para>
    /// <para>
    /// Default: 100
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(100)]
    public int? Limit { get; init; }

    /// <summary>
    /// Contains query criteria for the search.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public SearchEventsQuery? Query { get; init; }
}

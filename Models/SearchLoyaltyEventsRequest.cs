using System.Text.Json.Serialization;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// A request to search for loyalty events.
/// </summary>
public record SearchLoyaltyEventsRequest
{
    /// <summary>
    /// Represents a query used to search for loyalty events.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public LoyaltyEventQuery? Query { get; init; }

    /// <summary>
    /// The maximum number of results to include in the response.
    /// The last page might contain fewer events.
    /// The default is 30 events.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(30)]
    public int? Limit { get; init; }

    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this to retrieve the next set of results for your original query.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }
}

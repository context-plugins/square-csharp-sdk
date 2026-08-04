using System.Text.Json.Serialization;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:Labor-SearchScheduledShift">SearchScheduledShift</see> request.
/// </summary>
public record SearchScheduledShiftsRequest
{
    /// <summary>
    /// Represents filter and sort criteria for the <c>query</c> field in a
    /// <see href="api-endpoint:Labor-SearchScheduledShifts">SearchScheduledShifts</see> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public ScheduledShiftQuery? Query { get; init; }

    /// <summary>
    /// The maximum number of results to return in a single response page. The default value is 50.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(50)]
    public int? Limit { get; init; }

    /// <summary>
    /// The pagination cursor returned by the previous call to this endpoint. Provide
    /// this cursor to retrieve the next page of results for your original request. For more
    /// information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }
}

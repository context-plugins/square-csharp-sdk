using System.Text.Json.Serialization;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// A request for a filtered and sorted set of <c>Shift</c> objects.
/// </summary>
public record SearchShiftsRequest
{
    /// <summary>
    /// The parameters of a <c>Shift</c> search query, which includes filter and sort options.
    /// <para>
    /// Deprecated at Square API version 2025-05-21. See the <see href="https://developer.squareup.com/docs/labor-api/what-it-does#migration-notes">migration notes</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public ShiftQuery? Query { get; init; }

    /// <summary>
    /// The number of resources in a page (200 by default).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(200)]
    public int? Limit { get; init; }

    /// <summary>
    /// An opaque cursor for fetching the next page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }
}

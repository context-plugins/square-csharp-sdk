using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Defines sort criteria for a <see href="api-endpoint:Labor-SearchScheduledShifts">SearchScheduledShifts</see>
/// request.
/// </summary>
public record ScheduledShiftSort
{
    /// <summary>
    /// Defines valid values for the <c>field</c> sort setting in a
    /// <see href="api-endpoint:Labor-SearchScheduledShifts">SearchScheduledShifts</see> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field")]
    public ScheduledShiftSortField? Field { get; init; }

    /// <summary>
    /// The order (e.g., chronological or alphabetical) in which results from a request are returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public SortOrder? Order { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

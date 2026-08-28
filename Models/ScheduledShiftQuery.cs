using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents filter and sort criteria for the <c>query</c> field in a
/// <see href="api-endpoint:Labor-SearchScheduledShifts">SearchScheduledShifts</see> request.
/// </summary>
public record ScheduledShiftQuery
{
    /// <summary>
    /// Defines filter criteria for a <see href="api-endpoint:Labor-SearchScheduledShifts">SearchScheduledShifts</see>
    /// request. Multiple filters in a query are combined as an <c>AND</c> operation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public ScheduledShiftFilter? Filter { get; init; }

    /// <summary>
    /// Defines sort criteria for a <see href="api-endpoint:Labor-SearchScheduledShifts">SearchScheduledShifts</see>
    /// request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort")]
    public ScheduledShiftSort? Sort { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

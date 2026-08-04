using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// The hours of operation for a location.
/// </summary>
public record BusinessHours
{
    /// <summary>
    /// The list of time periods during which the business is open. There can be at most 10 periods per day.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("periods")]
    public IReadOnlyList<BusinessHoursPeriod?>? Periods { get; init; }
}

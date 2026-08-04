using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// A <c>Timecard</c> search query filter parameter that sets a range of days that
/// a <c>Timecard</c> must start or end in before passing the filter condition.
/// </summary>
public record TimecardWorkday
{
    /// <summary>
    /// A range defined by two dates. Used for filtering a query for Connect v2
    /// objects that have date properties.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date_range")]
    public DateRange? DateRange { get; init; }

    /// <summary>
    /// Defines the logic used to apply a workday filter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("match_timecards_by")]
    public TimecardWorkdayMatcher? MatchTimecardsBy { get; init; }

    /// <summary>
    /// Location-specific timezones convert workdays to datetime filters.
    /// Every location included in the query must have a timezone or this field
    /// must be provided as a fallback. Format: the IANA timezone database
    /// identifier for the relevant timezone.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("default_timezone")]
    public string? DefaultTimezone { get; init; }
}

using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Defines the logic used to apply a workday filter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TimecardWorkdayMatcher>))]
public sealed record TimecardWorkdayMatcher : StringEnum<TimecardWorkdayMatcher>
{
    private TimecardWorkdayMatcher(string value) : base(value)
    {
    }

    /// <summary>
    /// All timecards that start on or after the specified workday
    /// </summary>
    public static readonly TimecardWorkdayMatcher StartAt = new("START_AT");

    /// <summary>
    /// All timecards that end on or before the specified workday
    /// </summary>
    public static readonly TimecardWorkdayMatcher EndAt = new("END_AT");

    /// <summary>
    /// All timecards that start between the start and end workdays (inclusive)
    /// </summary>
    public static readonly TimecardWorkdayMatcher Intersection = new("INTERSECTION");

    public static TimecardWorkdayMatcher FromValue(string value) => FromValueCore(value);
}

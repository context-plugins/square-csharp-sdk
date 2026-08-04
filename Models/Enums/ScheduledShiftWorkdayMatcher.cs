using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Defines the logic used to apply a workday filter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScheduledShiftWorkdayMatcher>))]
public sealed record ScheduledShiftWorkdayMatcher : StringEnum<ScheduledShiftWorkdayMatcher>
{
    private ScheduledShiftWorkdayMatcher(string value) : base(value)
    {
    }

    /// <summary>
    /// All shifts that start on or after the specified workday
    /// </summary>
    public static readonly ScheduledShiftWorkdayMatcher StartAt = new("START_AT");

    /// <summary>
    /// All shifts that end on or before the specified workday
    /// </summary>
    public static readonly ScheduledShiftWorkdayMatcher EndAt = new("END_AT");

    /// <summary>
    /// All shifts that start between the start and end workdays (inclusive)
    /// </summary>
    public static readonly ScheduledShiftWorkdayMatcher Intersection = new("INTERSECTION");

    public static ScheduledShiftWorkdayMatcher FromValue(string value) => FromValueCore(value);
}

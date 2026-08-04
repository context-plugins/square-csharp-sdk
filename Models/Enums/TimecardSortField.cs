using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Enumerates the <c>Timecard</c> fields to sort on.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TimecardSortField>))]
public sealed record TimecardSortField : StringEnum<TimecardSortField>
{
    private TimecardSortField(string value) : base(value)
    {
    }

    /// <summary>
    /// The start date/time of a <c>Timecard</c>
    /// </summary>
    public static readonly TimecardSortField StartAt = new("START_AT");

    /// <summary>
    /// The end date/time of a <c>Timecard</c>
    /// </summary>
    public static readonly TimecardSortField EndAt = new("END_AT");

    /// <summary>
    /// The date/time that a <c>Timecard</c> is created
    /// </summary>
    public static readonly TimecardSortField CreatedAt = new("CREATED_AT");

    /// <summary>
    /// The most recent date/time that a <c>Timecard</c> is updated
    /// </summary>
    public static readonly TimecardSortField UpdatedAt = new("UPDATED_AT");

    public static TimecardSortField FromValue(string value) => FromValueCore(value);
}

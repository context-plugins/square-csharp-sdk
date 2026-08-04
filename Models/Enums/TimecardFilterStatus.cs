using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Specifies the <c>status</c> of <c>Timecard</c> records to be returned.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TimecardFilterStatus>))]
public sealed record TimecardFilterStatus : StringEnum<TimecardFilterStatus>
{
    private TimecardFilterStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// Timecards that have been started and not ended.
    /// </summary>
    public static readonly TimecardFilterStatus Open = new("OPEN");

    /// <summary>
    /// Timecards that have been started and ended.
    /// </summary>
    public static readonly TimecardFilterStatus Closed = new("CLOSED");

    public static TimecardFilterStatus FromValue(string value) => FromValueCore(value);
}

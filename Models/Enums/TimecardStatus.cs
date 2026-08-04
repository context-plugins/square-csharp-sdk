using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// <b>Read only</b> Enumerates the possible status of a <see href="entity:Timecard">timecard</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TimecardStatus>))]
public sealed record TimecardStatus : StringEnum<TimecardStatus>
{
    private TimecardStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The timecard has a <c>start_at</c> time but no <c>end_at</c> time, indicating an ongoing shift.
    /// </summary>
    public static readonly TimecardStatus Open = new("OPEN");

    /// <summary>
    /// The timecard has both <c>start_at</c> and <c>end_at</c> times, indicating a completed shift.
    /// </summary>
    public static readonly TimecardStatus Closed = new("CLOSED");

    public static TimecardStatus FromValue(string value) => FromValueCore(value);
}

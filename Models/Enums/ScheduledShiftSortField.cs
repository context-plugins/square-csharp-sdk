using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Defines valid values for the <c>field</c> sort setting in a
/// <see href="api-endpoint:Labor-SearchScheduledShifts">SearchScheduledShifts</see> request.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScheduledShiftSortField>))]
public sealed record ScheduledShiftSortField : StringEnum<ScheduledShiftSortField>
{
    private ScheduledShiftSortField(string value) : base(value)
    {
    }

    /// <summary>
    /// Sort by the start time of the shift.
    /// </summary>
    public static readonly ScheduledShiftSortField StartAt = new("START_AT");

    /// <summary>
    /// Sort by the end time of the shift.
    /// </summary>
    public static readonly ScheduledShiftSortField EndAt = new("END_AT");

    /// <summary>
    /// Sort by the creation date of the shift.
    /// </summary>
    public static readonly ScheduledShiftSortField CreatedAt = new("CREATED_AT");

    /// <summary>
    /// Sort by the last updated date of the shift.
    /// </summary>
    public static readonly ScheduledShiftSortField UpdatedAt = new("UPDATED_AT");

    public static ScheduledShiftSortField FromValue(string value) => FromValueCore(value);
}

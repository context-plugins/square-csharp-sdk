using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Enumerates the <c>Shift</c> fields to sort on.
/// <para>
/// Deprecated at Square API version 2025-05-21. See the <see href="https://developer.squareup.com/docs/labor-api/what-it-does#migration-notes">migration notes</see>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ShiftSortField>))]
public sealed record ShiftSortField : StringEnum<ShiftSortField>
{
    private ShiftSortField(string value) : base(value)
    {
    }

    /// <summary>
    /// The start date/time of a <c>Shift</c>
    /// </summary>
    public static readonly ShiftSortField StartAt = new("START_AT");

    /// <summary>
    /// The end date/time of a <c>Shift</c>
    /// </summary>
    public static readonly ShiftSortField EndAt = new("END_AT");

    /// <summary>
    /// The date/time that a <c>Shift</c> is created
    /// </summary>
    public static readonly ShiftSortField CreatedAt = new("CREATED_AT");

    /// <summary>
    /// The most recent date/time that a <c>Shift</c> is updated
    /// </summary>
    public static readonly ShiftSortField UpdatedAt = new("UPDATED_AT");

    public static ShiftSortField FromValue(string value) => FromValueCore(value);
}

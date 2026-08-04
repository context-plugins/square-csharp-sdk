using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Specifies the <c>status</c> of <c>Shift</c> records to be returned.
/// <para>
/// Deprecated at Square API version 2025-05-21. See the <see href="https://developer.squareup.com/docs/labor-api/what-it-does#migration-notes">migration notes</see>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ShiftFilterStatus>))]
public sealed record ShiftFilterStatus : StringEnum<ShiftFilterStatus>
{
    private ShiftFilterStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// Shifts that have been started and not ended.
    /// </summary>
    public static readonly ShiftFilterStatus Open = new("OPEN");

    /// <summary>
    /// Shifts that have been started and ended.
    /// </summary>
    public static readonly ShiftFilterStatus Closed = new("CLOSED");

    public static ShiftFilterStatus FromValue(string value) => FromValueCore(value);
}

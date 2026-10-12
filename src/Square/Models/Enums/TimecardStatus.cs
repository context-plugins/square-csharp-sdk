using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// <b>Read only</b> Enumerates the possible status of a <see href="entity:Timecard">timecard</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TimecardStatus>))]
public sealed record TimecardStatus : OpenStringEnum<TimecardStatus>
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

    public TResult Match<TResult>(Func<TResult> onOpen, Func<TResult> onClosed, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Open => onOpen(),
            _ when this == Closed => onClosed(),
            _ => otherwise(Value)
        };

    public void Match(Action onOpen, Action onClosed, Action<string> otherwise)
    {
        if (this == Open) onOpen();
        else if (this == Closed) onClosed();
        else otherwise(Value);
    }
}

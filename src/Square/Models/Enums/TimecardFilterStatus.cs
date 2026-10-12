using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Specifies the <c>status</c> of <c>Timecard</c> records to be returned.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TimecardFilterStatus>))]
public sealed record TimecardFilterStatus : OpenStringEnum<TimecardFilterStatus>
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

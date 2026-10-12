using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Enumerates the possible status of a <c>Shift</c>.
/// <para>
/// Deprecated at Square API version 2025-05-21. See the <see href="https://developer.squareup.com/docs/labor-api/what-it-does#migration-notes">migration notes</see>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ShiftStatus>))]
public sealed record ShiftStatus : OpenStringEnum<ShiftStatus>
{
    private ShiftStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// Employee started a work shift and the shift is not complete
    /// </summary>
    public static readonly ShiftStatus Open = new("OPEN");

    /// <summary>
    /// Employee started and ended a work shift.
    /// </summary>
    public static readonly ShiftStatus Closed = new("CLOSED");

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

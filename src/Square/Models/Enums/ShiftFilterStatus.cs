using System;
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
public sealed record ShiftFilterStatus : OpenStringEnum<ShiftFilterStatus>
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

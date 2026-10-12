using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The current state of a cash drawer shift.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CashDrawerShiftState>))]
public sealed record CashDrawerShiftState : OpenStringEnum<CashDrawerShiftState>
{
    private CashDrawerShiftState(string value) : base(value)
    {
    }

    /// <summary>
    /// An open cash drawer shift.
    /// </summary>
    public static readonly CashDrawerShiftState Open = new("OPEN");

    /// <summary>
    /// A cash drawer shift that is ended but has not yet had an employee content audit.
    /// </summary>
    public static readonly CashDrawerShiftState Ended = new("ENDED");

    /// <summary>
    /// An ended cash drawer shift that is closed with a completed employee
    /// content audit and recorded result.
    /// </summary>
    public static readonly CashDrawerShiftState Closed = new("CLOSED");

    public TResult Match<TResult>(Func<TResult> onOpen,
        Func<TResult> onEnded,
        Func<TResult> onClosed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Open => onOpen(),
            _ when this == Ended => onEnded(),
            _ when this == Closed => onClosed(),
            _ => otherwise(Value)
        };

    public void Match(Action onOpen, Action onEnded, Action onClosed, Action<string> otherwise)
    {
        if (this == Open) onOpen();
        else if (this == Ended) onEnded();
        else if (this == Closed) onClosed();
        else otherwise(Value);
    }
}

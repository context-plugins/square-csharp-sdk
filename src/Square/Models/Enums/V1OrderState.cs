using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1OrderState>))]
public sealed record V1OrderState : OpenStringEnum<V1OrderState>
{
    private V1OrderState(string value) : base(value)
    {
    }

    public static readonly V1OrderState Pending = new("PENDING");

    public static readonly V1OrderState Open = new("OPEN");

    public static readonly V1OrderState Completed = new("COMPLETED");

    public static readonly V1OrderState Canceled = new("CANCELED");

    public static readonly V1OrderState Refunded = new("REFUNDED");

    public static readonly V1OrderState Rejected = new("REJECTED");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onOpen,
        Func<TResult> onCompleted,
        Func<TResult> onCanceled,
        Func<TResult> onRefunded,
        Func<TResult> onRejected,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Open => onOpen(),
            _ when this == Completed => onCompleted(),
            _ when this == Canceled => onCanceled(),
            _ when this == Refunded => onRefunded(),
            _ when this == Rejected => onRejected(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onOpen,
        Action onCompleted,
        Action onCanceled,
        Action onRefunded,
        Action onRejected,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Open) onOpen();
        else if (this == Completed) onCompleted();
        else if (this == Canceled) onCanceled();
        else if (this == Refunded) onRefunded();
        else if (this == Rejected) onRejected();
        else otherwise(Value);
    }
}

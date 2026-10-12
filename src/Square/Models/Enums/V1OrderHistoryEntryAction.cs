using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1OrderHistoryEntryAction>))]
public sealed record V1OrderHistoryEntryAction : OpenStringEnum<V1OrderHistoryEntryAction>
{
    private V1OrderHistoryEntryAction(string value) : base(value)
    {
    }

    public static readonly V1OrderHistoryEntryAction OrderPlaced = new("ORDER_PLACED");

    public static readonly V1OrderHistoryEntryAction Declined = new("DECLINED");

    public static readonly V1OrderHistoryEntryAction PaymentReceived = new("PAYMENT_RECEIVED");

    public static readonly V1OrderHistoryEntryAction Canceled = new("CANCELED");

    public static readonly V1OrderHistoryEntryAction Completed = new("COMPLETED");

    public static readonly V1OrderHistoryEntryAction Refunded = new("REFUNDED");

    public static readonly V1OrderHistoryEntryAction Expired = new("EXPIRED");

    public TResult Match<TResult>(Func<TResult> onOrderPlaced,
        Func<TResult> onDeclined,
        Func<TResult> onPaymentReceived,
        Func<TResult> onCanceled,
        Func<TResult> onCompleted,
        Func<TResult> onRefunded,
        Func<TResult> onExpired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == OrderPlaced => onOrderPlaced(),
            _ when this == Declined => onDeclined(),
            _ when this == PaymentReceived => onPaymentReceived(),
            _ when this == Canceled => onCanceled(),
            _ when this == Completed => onCompleted(),
            _ when this == Refunded => onRefunded(),
            _ when this == Expired => onExpired(),
            _ => otherwise(Value)
        };

    public void Match(Action onOrderPlaced,
        Action onDeclined,
        Action onPaymentReceived,
        Action onCanceled,
        Action onCompleted,
        Action onRefunded,
        Action onExpired,
        Action<string> otherwise)
    {
        if (this == OrderPlaced) onOrderPlaced();
        else if (this == Declined) onDeclined();
        else if (this == PaymentReceived) onPaymentReceived();
        else if (this == Canceled) onCanceled();
        else if (this == Completed) onCompleted();
        else if (this == Refunded) onRefunded();
        else if (this == Expired) onExpired();
        else otherwise(Value);
    }
}

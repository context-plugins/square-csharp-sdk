using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1UpdateOrderRequestAction>))]
public sealed record V1UpdateOrderRequestAction : OpenStringEnum<V1UpdateOrderRequestAction>
{
    private V1UpdateOrderRequestAction(string value) : base(value)
    {
    }

    public static readonly V1UpdateOrderRequestAction Complete = new("COMPLETE");

    public static readonly V1UpdateOrderRequestAction Cancel = new("CANCEL");

    public static readonly V1UpdateOrderRequestAction Refund = new("REFUND");

    public TResult Match<TResult>(Func<TResult> onComplete,
        Func<TResult> onCancel,
        Func<TResult> onRefund,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Complete => onComplete(),
            _ when this == Cancel => onCancel(),
            _ when this == Refund => onRefund(),
            _ => otherwise(Value)
        };

    public void Match(Action onComplete, Action onCancel, Action onRefund, Action<string> otherwise)
    {
        if (this == Complete) onComplete();
        else if (this == Cancel) onCancel();
        else if (this == Refund) onRefund();
        else otherwise(Value);
    }
}

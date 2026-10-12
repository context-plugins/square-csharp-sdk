using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Describes the action to be applied to a delayed capture payment when the delay_duration
/// has elapsed.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentOptionsDelayAction>))]
public sealed record PaymentOptionsDelayAction : OpenStringEnum<PaymentOptionsDelayAction>
{
    private PaymentOptionsDelayAction(string value) : base(value)
    {
    }

    /// <summary>
    /// Indicates that the payment should be automatically canceled when the delay duration
    /// elapses.
    /// </summary>
    public static readonly PaymentOptionsDelayAction Cancel = new("CANCEL");

    /// <summary>
    /// Indicates that the payment should be automatically completed when the delay duration
    /// elapses.
    /// </summary>
    public static readonly PaymentOptionsDelayAction Complete = new("COMPLETE");

    public TResult Match<TResult>(Func<TResult> onCancel, Func<TResult> onComplete, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Cancel => onCancel(),
            _ when this == Complete => onComplete(),
            _ => otherwise(Value)
        };

    public void Match(Action onCancel, Action onComplete, Action<string> otherwise)
    {
        if (this == Cancel) onCancel();
        else if (this == Complete) onComplete();
        else otherwise(Value);
    }
}

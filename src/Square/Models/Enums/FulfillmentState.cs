using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The current state of this fulfillment.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FulfillmentState>))]
public sealed record FulfillmentState : OpenStringEnum<FulfillmentState>
{
    private FulfillmentState(string value) : base(value)
    {
    }

    /// <summary>
    /// Indicates that the fulfillment has been proposed.
    /// </summary>
    public static readonly FulfillmentState Proposed = new("PROPOSED");

    /// <summary>
    /// Indicates that the fulfillment has been reserved.
    /// </summary>
    public static readonly FulfillmentState Reserved = new("RESERVED");

    /// <summary>
    /// Indicates that the fulfillment has been prepared.
    /// </summary>
    public static readonly FulfillmentState Prepared = new("PREPARED");

    /// <summary>
    /// Indicates that the fulfillment was successfully completed.
    /// </summary>
    public static readonly FulfillmentState Completed = new("COMPLETED");

    /// <summary>
    /// Indicates that the fulfillment was canceled.
    /// </summary>
    public static readonly FulfillmentState Canceled = new("CANCELED");

    /// <summary>
    /// Indicates that the fulfillment failed to be completed, but was not explicitly
    /// canceled.
    /// </summary>
    public static readonly FulfillmentState Failed = new("FAILED");

    public TResult Match<TResult>(Func<TResult> onProposed,
        Func<TResult> onReserved,
        Func<TResult> onPrepared,
        Func<TResult> onCompleted,
        Func<TResult> onCanceled,
        Func<TResult> onFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Proposed => onProposed(),
            _ when this == Reserved => onReserved(),
            _ when this == Prepared => onPrepared(),
            _ when this == Completed => onCompleted(),
            _ when this == Canceled => onCanceled(),
            _ when this == Failed => onFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onProposed,
        Action onReserved,
        Action onPrepared,
        Action onCompleted,
        Action onCanceled,
        Action onFailed,
        Action<string> otherwise)
    {
        if (this == Proposed) onProposed();
        else if (this == Reserved) onReserved();
        else if (this == Prepared) onPrepared();
        else if (this == Completed) onCompleted();
        else if (this == Canceled) onCanceled();
        else if (this == Failed) onFailed();
        else otherwise(Value);
    }
}

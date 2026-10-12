using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates a refund's current status.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RefundStatus>))]
public sealed record RefundStatus : OpenStringEnum<RefundStatus>
{
    private RefundStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The refund is pending.
    /// </summary>
    public static readonly RefundStatus Pending = new("PENDING");

    /// <summary>
    /// The refund has been approved by Square.
    /// </summary>
    public static readonly RefundStatus Approved = new("APPROVED");

    /// <summary>
    /// The refund has been rejected by Square.
    /// </summary>
    public static readonly RefundStatus Rejected = new("REJECTED");

    /// <summary>
    /// The refund failed.
    /// </summary>
    public static readonly RefundStatus Failed = new("FAILED");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onApproved,
        Func<TResult> onRejected,
        Func<TResult> onFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Approved => onApproved(),
            _ when this == Rejected => onRejected(),
            _ when this == Failed => onFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending, Action onApproved, Action onRejected, Action onFailed, Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Approved) onApproved();
        else if (this == Rejected) onRejected();
        else if (this == Failed) onFailed();
        else otherwise(Value);
    }
}

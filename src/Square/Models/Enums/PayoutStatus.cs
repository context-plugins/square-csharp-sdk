using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Payout status types
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PayoutStatus>))]
public sealed record PayoutStatus : OpenStringEnum<PayoutStatus>
{
    private PayoutStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// Indicates that the payout was successfully sent to the banking destination.
    /// </summary>
    public static readonly PayoutStatus Sent = new("SENT");

    /// <summary>
    /// Indicates that the payout was rejected by the banking destination.
    /// </summary>
    public static readonly PayoutStatus Failed = new("FAILED");

    /// <summary>
    /// Indicates that the payout has successfully completed.
    /// </summary>
    public static readonly PayoutStatus Paid = new("PAID");

    public TResult Match<TResult>(Func<TResult> onSent,
        Func<TResult> onFailed,
        Func<TResult> onPaid,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Sent => onSent(),
            _ when this == Failed => onFailed(),
            _ when this == Paid => onPaid(),
            _ => otherwise(Value)
        };

    public void Match(Action onSent, Action onFailed, Action onPaid, Action<string> otherwise)
    {
        if (this == Sent) onSent();
        else if (this == Failed) onFailed();
        else if (this == Paid) onPaid();
        else otherwise(Value);
    }
}

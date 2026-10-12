using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the bank account payment's current status.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TenderBankAccountDetailsStatus>))]
public sealed record TenderBankAccountDetailsStatus : OpenStringEnum<TenderBankAccountDetailsStatus>
{
    private TenderBankAccountDetailsStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The bank account payment is in progress.
    /// </summary>
    public static readonly TenderBankAccountDetailsStatus Pending = new("PENDING");

    /// <summary>
    /// The bank account payment has been completed.
    /// </summary>
    public static readonly TenderBankAccountDetailsStatus Completed = new("COMPLETED");

    /// <summary>
    /// The bank account payment failed.
    /// </summary>
    public static readonly TenderBankAccountDetailsStatus Failed = new("FAILED");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onCompleted,
        Func<TResult> onFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Completed => onCompleted(),
            _ when this == Failed => onFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending, Action onCompleted, Action onFailed, Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Completed) onCompleted();
        else if (this == Failed) onFailed();
        else otherwise(Value);
    }
}

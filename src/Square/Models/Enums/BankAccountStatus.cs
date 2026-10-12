using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the current verification status of a <c>BankAccount</c> object.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BankAccountStatus>))]
public sealed record BankAccountStatus : OpenStringEnum<BankAccountStatus>
{
    private BankAccountStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// Indicates that the verification process has started. Some features
    /// (for example, creditable or debitable) may be provisionally enabled on the bank
    /// account.
    /// </summary>
    public static readonly BankAccountStatus VerificationInProgress = new("VERIFICATION_IN_PROGRESS");

    /// <summary>
    /// Indicates that the bank account was successfully verified.
    /// </summary>
    public static readonly BankAccountStatus Verified = new("VERIFIED");

    /// <summary>
    /// Indicates that the bank account is disabled and is permanently unusable
    /// for funds transfer. A bank account can be disabled because of a failed verification
    /// attempt or a failed deposit attempt.
    /// </summary>
    public static readonly BankAccountStatus Disabled = new("DISABLED");

    public TResult Match<TResult>(Func<TResult> onVerificationInProgress,
        Func<TResult> onVerified,
        Func<TResult> onDisabled,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == VerificationInProgress => onVerificationInProgress(),
            _ when this == Verified => onVerified(),
            _ when this == Disabled => onDisabled(),
            _ => otherwise(Value)
        };

    public void Match(Action onVerificationInProgress, Action onVerified, Action onDisabled, Action<string> otherwise)
    {
        if (this == VerificationInProgress) onVerificationInProgress();
        else if (this == Verified) onVerified();
        else if (this == Disabled) onDisabled();
        else otherwise(Value);
    }
}

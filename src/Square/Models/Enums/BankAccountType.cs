using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the financial purpose of the bank account.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BankAccountType>))]
public sealed record BankAccountType : OpenStringEnum<BankAccountType>
{
    private BankAccountType(string value) : base(value)
    {
    }

    /// <summary>
    /// An account at a financial institution against which checks can be
    /// drawn by the account depositor.
    /// </summary>
    public static readonly BankAccountType Checking = new("CHECKING");

    /// <summary>
    /// An account at a financial institution that pays interest but cannot be
    /// used directly as money in the narrow sense of a medium of exchange.
    /// </summary>
    public static readonly BankAccountType Savings = new("SAVINGS");

    /// <summary>
    /// An account at a financial institution that contains a deposit of funds
    /// and/or securities.
    /// </summary>
    public static readonly BankAccountType Investment = new("INVESTMENT");

    /// <summary>
    /// An account at a financial institution which cannot be described by the
    /// other types.
    /// </summary>
    public static readonly BankAccountType Other = new("OTHER");

    /// <summary>
    /// An account at a financial institution against which checks can be
    /// drawn specifically for business purposes (non-personal use).
    /// </summary>
    public static readonly BankAccountType BusinessChecking = new("BUSINESS_CHECKING");

    public TResult Match<TResult>(Func<TResult> onChecking,
        Func<TResult> onSavings,
        Func<TResult> onInvestment,
        Func<TResult> onOther,
        Func<TResult> onBusinessChecking,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Checking => onChecking(),
            _ when this == Savings => onSavings(),
            _ when this == Investment => onInvestment(),
            _ when this == Other => onOther(),
            _ when this == BusinessChecking => onBusinessChecking(),
            _ => otherwise(Value)
        };

    public void Match(Action onChecking,
        Action onSavings,
        Action onInvestment,
        Action onOther,
        Action onBusinessChecking,
        Action<string> otherwise)
    {
        if (this == Checking) onChecking();
        else if (this == Savings) onSavings();
        else if (this == Investment) onInvestment();
        else if (this == Other) onOther();
        else if (this == BusinessChecking) onBusinessChecking();
        else otherwise(Value);
    }
}

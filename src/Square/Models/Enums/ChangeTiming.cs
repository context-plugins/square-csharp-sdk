using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Supported timings when a pending change, as an action, takes place to a subscription.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ChangeTiming>))]
public sealed record ChangeTiming : OpenStringEnum<ChangeTiming>
{
    private ChangeTiming(string value) : base(value)
    {
    }

    /// <summary>
    /// The action occurs immediately.
    /// </summary>
    public static readonly ChangeTiming Immediate = new("IMMEDIATE");

    /// <summary>
    /// The action occurs at the end of the billing cycle.
    /// </summary>
    public static readonly ChangeTiming EndOfBillingCycle = new("END_OF_BILLING_CYCLE");

    public TResult Match<TResult>(Func<TResult> onImmediate,
        Func<TResult> onEndOfBillingCycle,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Immediate => onImmediate(),
            _ when this == EndOfBillingCycle => onEndOfBillingCycle(),
            _ => otherwise(Value)
        };

    public void Match(Action onImmediate, Action onEndOfBillingCycle, Action<string> otherwise)
    {
        if (this == Immediate) onImmediate();
        else if (this == EndOfBillingCycle) onEndOfBillingCycle();
        else otherwise(Value);
    }
}

using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates whether the program is currently active.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyProgramStatus>))]
public sealed record LoyaltyProgramStatus : OpenStringEnum<LoyaltyProgramStatus>
{
    private LoyaltyProgramStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The loyalty program does not have an active subscription.
    /// Loyalty API requests fail.
    /// </summary>
    public static readonly LoyaltyProgramStatus Inactive = new("INACTIVE");

    /// <summary>
    /// The program is fully functional. The program has an active subscription.
    /// </summary>
    public static readonly LoyaltyProgramStatus Active = new("ACTIVE");

    public TResult Match<TResult>(Func<TResult> onInactive, Func<TResult> onActive, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Inactive => onInactive(),
            _ when this == Active => onActive(),
            _ => otherwise(Value)
        };

    public void Match(Action onInactive, Action onActive, Action<string> otherwise)
    {
        if (this == Inactive) onInactive();
        else if (this == Active) onActive();
        else otherwise(Value);
    }
}

using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Supported subscription statuses.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SubscriptionStatus>))]
public sealed record SubscriptionStatus : OpenStringEnum<SubscriptionStatus>
{
    private SubscriptionStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The subscription is pending to start in the future.
    /// </summary>
    public static readonly SubscriptionStatus Pending = new("PENDING");

    /// <summary>
    /// The subscription is active.
    /// </summary>
    public static readonly SubscriptionStatus Active = new("ACTIVE");

    /// <summary>
    /// The subscription is canceled.
    /// </summary>
    public static readonly SubscriptionStatus Canceled = new("CANCELED");

    /// <summary>
    /// The subscription is deactivated.
    /// </summary>
    public static readonly SubscriptionStatus Deactivated = new("DEACTIVATED");

    /// <summary>
    /// The subscription is paused.
    /// </summary>
    public static readonly SubscriptionStatus Paused = new("PAUSED");

    /// <summary>
    /// The subscription has completed all of its phases.
    /// </summary>
    public static readonly SubscriptionStatus Completed = new("COMPLETED");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onActive,
        Func<TResult> onCanceled,
        Func<TResult> onDeactivated,
        Func<TResult> onPaused,
        Func<TResult> onCompleted,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Active => onActive(),
            _ when this == Canceled => onCanceled(),
            _ when this == Deactivated => onDeactivated(),
            _ when this == Paused => onPaused(),
            _ when this == Completed => onCompleted(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onActive,
        Action onCanceled,
        Action onDeactivated,
        Action onPaused,
        Action onCompleted,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Active) onActive();
        else if (this == Canceled) onCanceled();
        else if (this == Deactivated) onDeactivated();
        else if (this == Paused) onPaused();
        else if (this == Completed) onCompleted();
        else otherwise(Value);
    }
}

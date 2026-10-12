using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Supported types of an event occurred to a subscription.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SubscriptionEventSubscriptionEventType>))]
public sealed record SubscriptionEventSubscriptionEventType : OpenStringEnum<SubscriptionEventSubscriptionEventType>
{
    private SubscriptionEventSubscriptionEventType(string value) : base(value)
    {
    }

    /// <summary>
    /// The subscription was started.
    /// </summary>
    public static readonly SubscriptionEventSubscriptionEventType StartSubscription = new("START_SUBSCRIPTION");

    /// <summary>
    /// The subscription plan was changed.
    /// </summary>
    public static readonly SubscriptionEventSubscriptionEventType PlanChange = new("PLAN_CHANGE");

    /// <summary>
    /// The subscription was stopped.
    /// </summary>
    public static readonly SubscriptionEventSubscriptionEventType StopSubscription = new("STOP_SUBSCRIPTION");

    /// <summary>
    /// The subscription was deactivated
    /// </summary>
    public static readonly SubscriptionEventSubscriptionEventType DeactivateSubscription = new(
        "DEACTIVATE_SUBSCRIPTION");

    /// <summary>
    /// The subscription was resumed.
    /// </summary>
    public static readonly SubscriptionEventSubscriptionEventType ResumeSubscription = new("RESUME_SUBSCRIPTION");

    /// <summary>
    /// The subscription was paused.
    /// </summary>
    public static readonly SubscriptionEventSubscriptionEventType PauseSubscription = new("PAUSE_SUBSCRIPTION");

    /// <summary>
    /// The billing anchor date was changed.
    /// </summary>
    public static readonly SubscriptionEventSubscriptionEventType BillingAnchorDateChanged = new(
        "BILLING_ANCHOR_DATE_CHANGED");

    public TResult Match<TResult>(Func<TResult> onStartSubscription,
        Func<TResult> onPlanChange,
        Func<TResult> onStopSubscription,
        Func<TResult> onDeactivateSubscription,
        Func<TResult> onResumeSubscription,
        Func<TResult> onPauseSubscription,
        Func<TResult> onBillingAnchorDateChanged,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == StartSubscription => onStartSubscription(),
            _ when this == PlanChange => onPlanChange(),
            _ when this == StopSubscription => onStopSubscription(),
            _ when this == DeactivateSubscription => onDeactivateSubscription(),
            _ when this == ResumeSubscription => onResumeSubscription(),
            _ when this == PauseSubscription => onPauseSubscription(),
            _ when this == BillingAnchorDateChanged => onBillingAnchorDateChanged(),
            _ => otherwise(Value)
        };

    public void Match(Action onStartSubscription,
        Action onPlanChange,
        Action onStopSubscription,
        Action onDeactivateSubscription,
        Action onResumeSubscription,
        Action onPauseSubscription,
        Action onBillingAnchorDateChanged,
        Action<string> otherwise)
    {
        if (this == StartSubscription) onStartSubscription();
        else if (this == PlanChange) onPlanChange();
        else if (this == StopSubscription) onStopSubscription();
        else if (this == DeactivateSubscription) onDeactivateSubscription();
        else if (this == ResumeSubscription) onResumeSubscription();
        else if (this == PauseSubscription) onPauseSubscription();
        else if (this == BillingAnchorDateChanged) onBillingAnchorDateChanged();
        else otherwise(Value);
    }
}

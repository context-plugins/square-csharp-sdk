using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Supported types of an event occurred to a subscription.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SubscriptionEventSubscriptionEventType>))]
public sealed record SubscriptionEventSubscriptionEventType : StringEnum<SubscriptionEventSubscriptionEventType>
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
    public static readonly SubscriptionEventSubscriptionEventType DeactivateSubscription = new("DEACTIVATE_SUBSCRIPTION");

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
    public static readonly SubscriptionEventSubscriptionEventType BillingAnchorDateChanged = new("BILLING_ANCHOR_DATE_CHANGED");

    public static SubscriptionEventSubscriptionEventType FromValue(string value) => FromValueCore(value);
}

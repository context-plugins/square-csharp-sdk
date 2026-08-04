using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Supported types of an action as a pending change to a subscription.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SubscriptionActionType>))]
public sealed record SubscriptionActionType : StringEnum<SubscriptionActionType>
{
    private SubscriptionActionType(string value) : base(value)
    {
    }

    /// <summary>
    /// The action to execute a scheduled cancellation of a subscription.
    /// </summary>
    public static readonly SubscriptionActionType Cancel = new("CANCEL");

    /// <summary>
    /// The action to execute a scheduled pause of a subscription.
    /// </summary>
    public static readonly SubscriptionActionType Pause = new("PAUSE");

    /// <summary>
    /// The action to execute a scheduled resumption of a subscription.
    /// </summary>
    public static readonly SubscriptionActionType Resume = new("RESUME");

    /// <summary>
    /// The action to execute a scheduled swap of a subscription plan in a subscription.
    /// </summary>
    public static readonly SubscriptionActionType SwapPlan = new("SWAP_PLAN");

    /// <summary>
    /// A billing anchor date change action.
    /// </summary>
    public static readonly SubscriptionActionType ChangeBillingAnchorDate = new("CHANGE_BILLING_ANCHOR_DATE");

    /// <summary>
    /// The action marking when a subscription completes a fixed number of phases.
    /// </summary>
    public static readonly SubscriptionActionType Complete = new("COMPLETE");

    public static SubscriptionActionType FromValue(string value) => FromValueCore(value);
}

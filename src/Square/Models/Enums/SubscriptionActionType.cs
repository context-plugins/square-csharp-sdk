using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Supported types of an action as a pending change to a subscription.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SubscriptionActionType>))]
public sealed record SubscriptionActionType : OpenStringEnum<SubscriptionActionType>
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

    public TResult Match<TResult>(Func<TResult> onCancel,
        Func<TResult> onPause,
        Func<TResult> onResume,
        Func<TResult> onSwapPlan,
        Func<TResult> onChangeBillingAnchorDate,
        Func<TResult> onComplete,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Cancel => onCancel(),
            _ when this == Pause => onPause(),
            _ when this == Resume => onResume(),
            _ when this == SwapPlan => onSwapPlan(),
            _ when this == ChangeBillingAnchorDate => onChangeBillingAnchorDate(),
            _ when this == Complete => onComplete(),
            _ => otherwise(Value)
        };

    public void Match(Action onCancel,
        Action onPause,
        Action onResume,
        Action onSwapPlan,
        Action onChangeBillingAnchorDate,
        Action onComplete,
        Action<string> otherwise)
    {
        if (this == Cancel) onCancel();
        else if (this == Pause) onPause();
        else if (this == Resume) onResume();
        else if (this == SwapPlan) onSwapPlan();
        else if (this == ChangeBillingAnchorDate) onChangeBillingAnchorDate();
        else if (this == Complete) onComplete();
        else otherwise(Value);
    }
}

using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the gift card state.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GiftCardStatus>))]
public sealed record GiftCardStatus : OpenStringEnum<GiftCardStatus>
{
    private GiftCardStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The gift card is active and can be used as a payment source.
    /// </summary>
    public static readonly GiftCardStatus Active = new("ACTIVE");

    /// <summary>
    /// Any activity that changes the gift card balance is permanently forbidden.
    /// </summary>
    public static readonly GiftCardStatus Deactivated = new("DEACTIVATED");

    /// <summary>
    /// Any activity that changes the gift card balance is temporarily forbidden.
    /// </summary>
    public static readonly GiftCardStatus Blocked = new("BLOCKED");

    /// <summary>
    /// The gift card is pending activation.
    /// This is the initial state when a gift card is created. Typically, you'll call
    /// <see href="api-endpoint:GiftCardActivities-CreateGiftCardActivity">CreateGiftCardActivity</see> to create an
    /// <c>ACTIVATE</c> activity that activates the gift card with an initial balance before first use.
    /// </summary>
    public static readonly GiftCardStatus Pending = new("PENDING");

    public TResult Match<TResult>(Func<TResult> onActive,
        Func<TResult> onDeactivated,
        Func<TResult> onBlocked,
        Func<TResult> onPending,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Deactivated => onDeactivated(),
            _ when this == Blocked => onBlocked(),
            _ when this == Pending => onPending(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive,
        Action onDeactivated,
        Action onBlocked,
        Action onPending,
        Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Deactivated) onDeactivated();
        else if (this == Blocked) onBlocked();
        else if (this == Pending) onPending();
        else otherwise(Value);
    }
}

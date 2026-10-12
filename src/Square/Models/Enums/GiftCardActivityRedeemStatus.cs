using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the status of a <see href="entity:GiftCard">gift card</see> redemption. This status is relevant only for
/// redemptions made from Square products (such as Square Point of Sale) because Square products use a
/// two-state process. Gift cards redeemed using the Gift Card Activities API always have a <c>COMPLETED</c> status.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GiftCardActivityRedeemStatus>))]
public sealed record GiftCardActivityRedeemStatus : OpenStringEnum<GiftCardActivityRedeemStatus>
{
    private GiftCardActivityRedeemStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The gift card redemption is pending. <c>PENDING</c> is a temporary status that applies when a
    /// gift card is redeemed from Square Point of Sale or another Square product. A <c>PENDING</c> status is updated to
    /// <c>COMPLETED</c> if the payment is captured or <c>CANCELED</c> if the authorization is voided.
    /// </summary>
    public static readonly GiftCardActivityRedeemStatus Pending = new("PENDING");

    /// <summary>
    /// The gift card redemption is completed.
    /// </summary>
    public static readonly GiftCardActivityRedeemStatus Completed = new("COMPLETED");

    /// <summary>
    /// The gift card redemption is canceled. A redemption is canceled if the authorization
    /// on the gift card is voided.
    /// </summary>
    public static readonly GiftCardActivityRedeemStatus Canceled = new("CANCELED");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onCompleted,
        Func<TResult> onCanceled,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Completed => onCompleted(),
            _ when this == Canceled => onCanceled(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending, Action onCompleted, Action onCanceled, Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Completed) onCompleted();
        else if (this == Canceled) onCanceled();
        else otherwise(Value);
    }
}

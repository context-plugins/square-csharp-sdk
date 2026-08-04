using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the status of a <see href="entity:GiftCard">gift card</see> redemption. This status is relevant only for
/// redemptions made from Square products (such as Square Point of Sale) because Square products use a
/// two-state process. Gift cards redeemed using the Gift Card Activities API always have a <c>COMPLETED</c> status.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GiftCardActivityRedeemStatus>))]
public sealed record GiftCardActivityRedeemStatus : StringEnum<GiftCardActivityRedeemStatus>
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

    public static GiftCardActivityRedeemStatus FromValue(string value) => FromValueCore(value);
}

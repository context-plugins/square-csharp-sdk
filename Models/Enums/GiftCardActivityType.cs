using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the type of <see href="entity:GiftCardActivity">gift card activity</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GiftCardActivityType>))]
public sealed record GiftCardActivityType : StringEnum<GiftCardActivityType>
{
    private GiftCardActivityType(string value) : base(value)
    {
    }

    /// <summary>
    /// Activated a gift card with a balance. When a gift card is activated, Square changes
    /// the gift card state from <c>PENDING</c> to <c>ACTIVE</c>. A gift card must be in the <c>ACTIVE</c> state
    /// to be used for other balance-changing activities.
    /// </summary>
    public static readonly GiftCardActivityType Activate = new("ACTIVATE");

    /// <summary>
    /// Loaded a gift card with additional funds.
    /// </summary>
    public static readonly GiftCardActivityType Load = new("LOAD");

    /// <summary>
    /// Redeemed a gift card for a purchase.
    /// </summary>
    public static readonly GiftCardActivityType Redeem = new("REDEEM");

    /// <summary>
    /// Set the balance of a gift card to zero.
    /// </summary>
    public static readonly GiftCardActivityType ClearBalance = new("CLEAR_BALANCE");

    /// <summary>
    /// Permanently blocked a gift card from balance-changing activities.
    /// </summary>
    public static readonly GiftCardActivityType Deactivate = new("DEACTIVATE");

    /// <summary>
    /// Added money to a gift card outside of a typical <c>ACTIVATE</c>, <c>LOAD</c>, or <c>REFUND</c> activity flow.
    /// </summary>
    public static readonly GiftCardActivityType AdjustIncrement = new("ADJUST_INCREMENT");

    /// <summary>
    /// Deducted money from a gift card outside of a typical <c>REDEEM</c> activity flow.
    /// </summary>
    public static readonly GiftCardActivityType AdjustDecrement = new("ADJUST_DECREMENT");

    /// <summary>
    /// Added money to a gift card from a refunded transaction. A <c>REFUND</c> activity might be linked to
    /// a Square payment, depending on how the payment and refund are processed. For example:
    /// - A payment processed by Square can be refunded to a <c>PENDING</c> or <c>ACTIVE</c> gift card using the Square
    /// Seller Dashboard, Square Point of Sale, or Refunds API.
    /// - A payment processed using a custom processing system can be refunded to the same gift card.
    /// </summary>
    public static readonly GiftCardActivityType Refund = new("REFUND");

    /// <summary>
    /// Added money to a gift card from a refunded transaction that was processed using a custom payment
    /// processing system and not linked to the gift card.
    /// </summary>
    public static readonly GiftCardActivityType UnlinkedActivityRefund = new("UNLINKED_ACTIVITY_REFUND");

    /// <summary>
    /// Imported a third-party gift card with a balance. <c>IMPORT</c> activities are managed
    /// by Square and cannot be created using the Gift Card Activities API.
    /// </summary>
    public static readonly GiftCardActivityType Import = new("IMPORT");

    /// <summary>
    /// Temporarily blocked a gift card from balance-changing activities. <c>BLOCK</c> activities
    /// are managed by Square and cannot be created using the Gift Card Activities API.
    /// </summary>
    public static readonly GiftCardActivityType Block = new("BLOCK");

    /// <summary>
    /// Unblocked a gift card, which enables it to resume balance-changing activities. <c>UNBLOCK</c>
    /// activities are managed by Square and cannot be created using the Gift Card Activities API.
    /// </summary>
    public static readonly GiftCardActivityType Unblock = new("UNBLOCK");

    /// <summary>
    /// Reversed the import of a third-party gift card, which sets the gift card state to
    /// <c>PENDING</c> and clears the balance. <c>IMPORT_REVERSAL</c> activities are managed by Square and
    /// cannot be created using the Gift Card Activities API.
    /// </summary>
    public static readonly GiftCardActivityType ImportReversal = new("IMPORT_REVERSAL");

    /// <summary>
    /// Deducted money from a gift card as the result of a transfer to the balance of another gift card.
    /// <c>TRANSFER_BALANCE_FROM</c> activities are managed by Square and cannot be created using the Gift Card Activities API.
    /// </summary>
    public static readonly GiftCardActivityType TransferBalanceFrom = new("TRANSFER_BALANCE_FROM");

    /// <summary>
    /// Added money to a gift card as the result of a transfer from the balance of another gift card.
    /// <c>TRANSFER_BALANCE_TO</c> activities are managed by Square and cannot be created using the Gift Card Activities API.
    /// </summary>
    public static readonly GiftCardActivityType TransferBalanceTo = new("TRANSFER_BALANCE_TO");

    public static GiftCardActivityType FromValue(string value) => FromValueCore(value);
}

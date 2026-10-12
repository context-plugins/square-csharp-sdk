using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the type of <see href="entity:GiftCardActivity">gift card activity</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GiftCardActivityType>))]
public sealed record GiftCardActivityType : OpenStringEnum<GiftCardActivityType>
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

    public TResult Match<TResult>(Func<TResult> onActivate,
        Func<TResult> onLoad,
        Func<TResult> onRedeem,
        Func<TResult> onClearBalance,
        Func<TResult> onDeactivate,
        Func<TResult> onAdjustIncrement,
        Func<TResult> onAdjustDecrement,
        Func<TResult> onRefund,
        Func<TResult> onUnlinkedActivityRefund,
        Func<TResult> onImport,
        Func<TResult> onBlock,
        Func<TResult> onUnblock,
        Func<TResult> onImportReversal,
        Func<TResult> onTransferBalanceFrom,
        Func<TResult> onTransferBalanceTo,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Activate => onActivate(),
            _ when this == Load => onLoad(),
            _ when this == Redeem => onRedeem(),
            _ when this == ClearBalance => onClearBalance(),
            _ when this == Deactivate => onDeactivate(),
            _ when this == AdjustIncrement => onAdjustIncrement(),
            _ when this == AdjustDecrement => onAdjustDecrement(),
            _ when this == Refund => onRefund(),
            _ when this == UnlinkedActivityRefund => onUnlinkedActivityRefund(),
            _ when this == Import => onImport(),
            _ when this == Block => onBlock(),
            _ when this == Unblock => onUnblock(),
            _ when this == ImportReversal => onImportReversal(),
            _ when this == TransferBalanceFrom => onTransferBalanceFrom(),
            _ when this == TransferBalanceTo => onTransferBalanceTo(),
            _ => otherwise(Value)
        };

    public void Match(Action onActivate,
        Action onLoad,
        Action onRedeem,
        Action onClearBalance,
        Action onDeactivate,
        Action onAdjustIncrement,
        Action onAdjustDecrement,
        Action onRefund,
        Action onUnlinkedActivityRefund,
        Action onImport,
        Action onBlock,
        Action onUnblock,
        Action onImportReversal,
        Action onTransferBalanceFrom,
        Action onTransferBalanceTo,
        Action<string> otherwise)
    {
        if (this == Activate) onActivate();
        else if (this == Load) onLoad();
        else if (this == Redeem) onRedeem();
        else if (this == ClearBalance) onClearBalance();
        else if (this == Deactivate) onDeactivate();
        else if (this == AdjustIncrement) onAdjustIncrement();
        else if (this == AdjustDecrement) onAdjustDecrement();
        else if (this == Refund) onRefund();
        else if (this == UnlinkedActivityRefund) onUnlinkedActivityRefund();
        else if (this == Import) onImport();
        else if (this == Block) onBlock();
        else if (this == Unblock) onUnblock();
        else if (this == ImportReversal) onImportReversal();
        else if (this == TransferBalanceFrom) onTransferBalanceFrom();
        else if (this == TransferBalanceTo) onTransferBalanceTo();
        else otherwise(Value);
    }
}

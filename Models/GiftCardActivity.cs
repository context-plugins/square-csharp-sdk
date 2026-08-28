using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents an action performed on a <see href="entity:GiftCard">gift card</see> that affects its state or balance.
/// A gift card activity contains information about a specific activity type. For example, a <c>REDEEM</c> activity
/// includes a <c>redeem_activity_details</c> field that contains information about the redemption.
/// </summary>
public record GiftCardActivity
{
    /// <summary>
    /// The Square-assigned ID of the gift card activity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Indicates the type of <see href="entity:GiftCardActivity">gift card activity</see>.
    /// </summary>
    [JsonPropertyName("type")]
    public required GiftCardActivityType Type { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:Location">business location</see> where the activity occurred.
    /// </summary>
    [JsonPropertyName("location_id")]
    public required string LocationId { get; init; }

    /// <summary>
    /// The timestamp when the gift card activity was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The gift card ID. When creating a gift card activity, <c>gift_card_id</c> is not required if
    /// <c>gift_card_gan</c> is specified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gift_card_id")]
    public string? GiftCardId { get; init; }

    /// <summary>
    /// The gift card account number (GAN). When creating a gift card activity, <c>gift_card_gan</c>
    /// is not required if <c>gift_card_id</c> is specified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gift_card_gan")]
    public string? GiftCardGan { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gift_card_balance_money")]
    public Money? GiftCardBalanceMoney { get; init; }

    /// <summary>
    /// Represents details about a <c>LOAD</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("load_activity_details")]
    public GiftCardActivityLoad? LoadActivityDetails { get; init; }

    /// <summary>
    /// Represents details about an <c>ACTIVATE</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("activate_activity_details")]
    public GiftCardActivityActivate? ActivateActivityDetails { get; init; }

    /// <summary>
    /// Represents details about a <c>REDEEM</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redeem_activity_details")]
    public GiftCardActivityRedeem? RedeemActivityDetails { get; init; }

    /// <summary>
    /// Represents details about a <c>CLEAR_BALANCE</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clear_balance_activity_details")]
    public GiftCardActivityClearBalance? ClearBalanceActivityDetails { get; init; }

    /// <summary>
    /// Represents details about a <c>DEACTIVATE</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deactivate_activity_details")]
    public GiftCardActivityDeactivate? DeactivateActivityDetails { get; init; }

    /// <summary>
    /// Represents details about an <c>ADJUST_INCREMENT</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjust_increment_activity_details")]
    public GiftCardActivityAdjustIncrement? AdjustIncrementActivityDetails { get; init; }

    /// <summary>
    /// Represents details about an <c>ADJUST_DECREMENT</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjust_decrement_activity_details")]
    public GiftCardActivityAdjustDecrement? AdjustDecrementActivityDetails { get; init; }

    /// <summary>
    /// Represents details about a <c>REFUND</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refund_activity_details")]
    public GiftCardActivityRefund? RefundActivityDetails { get; init; }

    /// <summary>
    /// Represents details about an <c>UNLINKED_ACTIVITY_REFUND</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unlinked_activity_refund_activity_details")]
    public GiftCardActivityUnlinkedActivityRefund? UnlinkedActivityRefundActivityDetails { get; init; }

    /// <summary>
    /// Represents details about an <c>IMPORT</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
    /// This activity type is used when Square imports a third-party gift card, in which case the
    /// <c>gan_source</c> of the gift card is set to <c>OTHER</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("import_activity_details")]
    public GiftCardActivityImport? ImportActivityDetails { get; init; }

    /// <summary>
    /// Represents details about a <c>BLOCK</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("block_activity_details")]
    public GiftCardActivityBlock? BlockActivityDetails { get; init; }

    /// <summary>
    /// Represents details about an <c>UNBLOCK</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unblock_activity_details")]
    public GiftCardActivityUnblock? UnblockActivityDetails { get; init; }

    /// <summary>
    /// Represents details about an <c>IMPORT_REVERSAL</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("import_reversal_activity_details")]
    public GiftCardActivityImportReversal? ImportReversalActivityDetails { get; init; }

    /// <summary>
    /// Represents details about a <c>TRANSFER_BALANCE_TO</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transfer_balance_to_activity_details")]
    public GiftCardActivityTransferBalanceTo? TransferBalanceToActivityDetails { get; init; }

    /// <summary>
    /// Represents details about a <c>TRANSFER_BALANCE_FROM</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transfer_balance_from_activity_details")]
    public GiftCardActivityTransferBalanceFrom? TransferBalanceFromActivityDetails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

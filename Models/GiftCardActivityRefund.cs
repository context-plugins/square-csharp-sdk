using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents details about a <c>REFUND</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
/// </summary>
public record GiftCardActivityRefund
{
    /// <summary>
    /// The ID of the refunded <c>REDEEM</c> gift card activity. Square populates this field if the
    /// <c>payment_id</c> in the corresponding <see href="api-endpoint:Refunds-RefundPayment">RefundPayment</see> request
    /// represents a gift card redemption.
    /// <para>
    /// For applications that use a custom payment processing system, this field is required when creating
    /// a <c>REFUND</c> activity. The provided <c>REDEEM</c> activity ID must be linked to the same gift card.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redeem_activity_id")]
    public string? RedeemActivityId { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount_money")]
    public Money? AmountMoney { get; init; }

    /// <summary>
    /// A client-specified ID that associates the gift card activity with an entity in another system.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_id")]
    public string? ReferenceId { get; init; }

    /// <summary>
    /// The ID of the refunded payment. Square populates this field if the refund is for a
    /// payment processed by Square. This field matches the <c>payment_id</c> in the corresponding
    /// <see href="api-endpoint:Refunds-RefundPayment">RefundPayment</see> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_id")]
    public string? PaymentId { get; init; }
}

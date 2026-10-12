using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents details about a <c>LOAD</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
/// </summary>
public record GiftCardActivityLoad
{
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
    /// The ID of the <see href="entity:Order">order</see> that contains the <c>GIFT_CARD</c> line item.
    /// <para>
    /// Applications that use the Square Orders API to process orders must specify the order ID in the
    /// <see href="api-endpoint:GiftCardActivities-CreateGiftCardActivity">CreateGiftCardActivity</see> request.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_id")]
    public string? OrderId { get; init; }

    /// <summary>
    /// The UID of the <c>GIFT_CARD</c> line item in the order that represents the additional funds for the gift card.
    /// <para>
    /// Applications that use the Square Orders API to process orders must specify the line item UID
    /// in the <see href="api-endpoint:GiftCardActivities-CreateGiftCardActivity">CreateGiftCardActivity</see> request.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("line_item_uid")]
    public string? LineItemUid { get; init; }

    /// <summary>
    /// A client-specified ID that associates the gift card activity with an entity in another system.
    /// <para>
    /// Applications that use a custom order processing system can use this field to track information related to
    /// an order or payment.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_id")]
    public string? ReferenceId { get; init; }

    /// <summary>
    /// The payment instrument IDs used to process the order for the additional funds, such as a credit card ID
    /// or bank account ID.
    /// <para>
    /// Applications that use a custom order processing system must specify payment instrument IDs in
    /// the <see href="api-endpoint:GiftCardActivities-CreateGiftCardActivity">CreateGiftCardActivity</see> request.
    /// Square uses this information to perform compliance checks.
    /// </para>
    /// <para>
    /// For applications that use the Square Orders API to process payments, Square has the necessary
    /// instrument IDs to perform compliance checks.
    /// </para>
    /// <para>
    /// Each buyer payment instrument ID can contain a maximum of 255 characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buyer_payment_instrument_ids")]
    public IReadOnlyList<string>? BuyerPaymentInstrumentIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

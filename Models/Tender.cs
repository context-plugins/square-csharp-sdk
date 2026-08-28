using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a tender (i.e., a method of payment) used in a Square transaction.
/// </summary>
public record Tender
{
    /// <summary>
    /// The tender's unique ID. It is the associated payment ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(192)]
    public string? Id { get; init; }

    /// <summary>
    /// The ID of the transaction's associated location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    [MaxLength(50)]
    public string? LocationId { get; init; }

    /// <summary>
    /// The ID of the tender's associated transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction_id")]
    [MaxLength(192)]
    public string? TransactionId { get; init; }

    /// <summary>
    /// The timestamp for when the tender was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    [MaxLength(32)]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// An optional note associated with the tender at the time of payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("note")]
    [MaxLength(500)]
    public string? Note { get; init; }

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
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tip_money")]
    public Money? TipMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processing_fee_money")]
    public Money? ProcessingFeeMoney { get; init; }

    /// <summary>
    /// If the tender is associated with a customer or represents a customer's card on file,
    /// this is the ID of the associated customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    [MaxLength(191)]
    public string? CustomerId { get; init; }

    /// <summary>
    /// Indicates a tender's type.
    /// </summary>
    [JsonPropertyName("type")]
    public required TenderType Type { get; init; }

    /// <summary>
    /// Represents additional details of a tender with <c>type</c> <c>CARD</c> or <c>SQUARE_GIFT_CARD</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card_details")]
    public TenderCardDetails? CardDetails { get; init; }

    /// <summary>
    /// Represents the details of a tender with <c>type</c> <c>CASH</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash_details")]
    public TenderCashDetails? CashDetails { get; init; }

    /// <summary>
    /// Represents the details of a tender with <c>type</c> <c>BANK_ACCOUNT</c>.
    /// <para>
    /// See <see href="entity:BankAccountPaymentDetails">BankAccountPaymentDetails</see>
    /// for more exposed details of a bank account payment.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_account_details")]
    public TenderBankAccountDetails? BankAccountDetails { get; init; }

    /// <summary>
    /// Represents the details of a tender with <c>type</c> <c>BUY_NOW_PAY_LATER</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buy_now_pay_later_details")]
    public TenderBuyNowPayLaterDetails? BuyNowPayLaterDetails { get; init; }

    /// <summary>
    /// Represents the details of a tender with <c>type</c> <c>SQUARE_ACCOUNT</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("square_account_details")]
    public TenderSquareAccountDetails? SquareAccountDetails { get; init; }

    /// <summary>
    /// Additional recipients (other than the merchant) receiving a portion of this tender.
    /// For example, fees assessed on the purchase by a third party integration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additional_recipients")]
    public IReadOnlyList<AdditionalRecipient?>? AdditionalRecipients { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:Payment">Payment</see> that corresponds to this tender.
    /// This value is only present for payments created with the v2 Payments API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_id")]
    [MaxLength(192)]
    public string? PaymentId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a payment request for an <see href="entity:Invoice">invoice</see>. Invoices can specify a maximum
/// of 13 payment requests, with up to 12 <c>INSTALLMENT</c> request types. For more information,
/// see <see href="https://developer.squareup.com/docs/invoices-api/create-publish-invoices#payment-requests">Configuring payment requests</see>.
/// <para>
/// Adding <c>INSTALLMENT</c> payment requests to an invoice requires an
/// <see href="https://developer.squareup.com/docs/invoices-api/overview#invoices-plus-subscription">Invoices Plus subscription</see>.
/// </para>
/// </summary>
public record InvoicePaymentRequest
{
    /// <summary>
    /// The Square-generated ID of the payment request in an <see href="entity:Invoice">invoice</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    [StringLength(255, MinimumLength = 1)]
    public string? Uid { get; init; }

    /// <summary>
    /// Specifies the action for Square to take for processing the invoice. For example,
    /// email the invoice, charge a customer's card on file, or do nothing. DEPRECATED at
    /// version 2021-01-21. The corresponding <c>request_method</c> field is replaced by the
    /// <c>Invoice.delivery_method</c> and <c>InvoicePaymentRequest.automatic_payment_source</c> fields.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_method")]
    public InvoiceRequestMethod? RequestMethod { get; init; }

    /// <summary>
    /// Indicates the type of the payment request. For more information, see
    /// <see href="https://developer.squareup.com/docs/invoices-api/create-publish-invoices#payment-requests">Configuring payment requests</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_type")]
    public InvoiceRequestType? RequestType { get; init; }

    /// <summary>
    /// The due date (in the invoice's time zone) for the payment request, in <c>YYYY-MM-DD</c> format. This field
    /// is required to create a payment request. If an <c>automatic_payment_source</c> is defined for the request, Square
    /// charges the payment source on this date.
    /// <para>
    /// After this date, the invoice becomes overdue. For example, a payment <c>due_date</c> of 2021-03-09 with a <c>timezone</c>
    /// of America/Los\_Angeles becomes overdue at midnight on March 9 in America/Los\_Angeles (which equals a UTC
    /// timestamp of 2021-03-10T08:00:00Z).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("due_date")]
    public string? DueDate { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fixed_amount_requested_money")]
    public Money? FixedAmountRequestedMoney { get; init; }

    /// <summary>
    /// Specifies the amount for the payment request in percentage:
    /// <para>
    /// - When the payment <c>request_type</c> is <c>DEPOSIT</c>, it is the percentage of the order's total amount.
    /// - When the payment <c>request_type</c> is <c>INSTALLMENT</c>, it is the percentage of the order's total less
    /// the deposit, if requested. The sum of the <c>percentage_requested</c> in all installment
    /// payment requests must be equal to 100.
    /// </para>
    /// <para>
    /// You cannot specify this when the payment <c>request_type</c> is <c>BALANCE</c> or when the
    /// payment request specifies the <c>fixed_amount_requested_money</c> field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("percentage_requested")]
    public string? PercentageRequested { get; init; }

    /// <summary>
    /// If set to true, the Square-hosted invoice page (the <c>public_url</c> field of the invoice)
    /// provides a place for the customer to pay a tip.
    /// <para>
    /// This field is allowed only on the final payment request
    /// and the payment <c>request_type</c> must be <c>BALANCE</c> or <c>INSTALLMENT</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tipping_enabled")]
    public bool? TippingEnabled { get; init; }

    /// <summary>
    /// Indicates the automatic payment method for an <see href="entity:InvoicePaymentRequest">invoice payment request</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("automatic_payment_source")]
    public InvoiceAutomaticPaymentSource? AutomaticPaymentSource { get; init; }

    /// <summary>
    /// The ID of the credit or debit card on file to charge for the payment request. To get the cards on file for a customer,
    /// call <see href="api-endpoint:Cards-ListCards">ListCards</see> and include the <c>customer_id</c> of the invoice recipient.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card_id")]
    [StringLength(255, MinimumLength = 1)]
    public string? CardId { get; init; }

    /// <summary>
    /// A list of one or more reminders to send for the payment request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reminders")]
    public IReadOnlyList<InvoicePaymentReminder>? Reminders { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("computed_amount_money")]
    public Money? ComputedAmountMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_completed_amount_money")]
    public Money? TotalCompletedAmountMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rounding_adjustment_included_money")]
    public Money? RoundingAdjustmentIncludedMoney { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

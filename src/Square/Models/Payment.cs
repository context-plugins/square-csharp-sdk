using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a payment processed by the Square API.
/// </summary>
public record Payment
{
    /// <summary>
    /// A unique ID for the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(192)]
    public string? Id { get; init; }

    /// <summary>
    /// The timestamp of when the payment was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    [MaxLength(32)]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The timestamp of when the payment was last updated, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    [MaxLength(32)]
    public string? UpdatedAt { get; init; }

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
    [JsonPropertyName("total_money")]
    public Money? TotalMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("app_fee_money")]
    public Money? AppFeeMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("approved_money")]
    public Money? ApprovedMoney { get; init; }

    /// <summary>
    /// The processing fees and fee adjustments assessed by Square for this payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processing_fee")]
    public IReadOnlyList<ProcessingFee>? ProcessingFee { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refunded_money")]
    public Money? RefundedMoney { get; init; }

    /// <summary>
    /// Indicates whether the payment is APPROVED, PENDING, COMPLETED, CANCELED, or FAILED.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    [MaxLength(50)]
    public string? Status { get; init; }

    /// <summary>
    /// The duration of time after the payment's creation when Square automatically applies the
    /// <c>delay_action</c> to the payment. This automatic <c>delay_action</c> applies only to payments that
    /// do not reach a terminal state (COMPLETED, CANCELED, or FAILED) before the <c>delay_duration</c>
    /// time period.
    /// <para>
    /// This field is specified as a time duration, in RFC 3339 format.
    /// </para>
    /// <para>
    /// Notes:
    /// This feature is only supported for card payments.
    /// </para>
    /// <para>
    /// Default:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Card-present payments: "PT36H" (36 hours) from the creation time.</description></item>
    ///   <item><description>Card-not-present payments: "P7D" (7 days) from the creation time.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delay_duration")]
    public string? DelayDuration { get; init; }

    /// <summary>
    /// The action to be applied to the payment when the <c>delay_duration</c> has elapsed.
    /// <para>
    /// Current values include <c>CANCEL</c> and <c>COMPLETE</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delay_action")]
    public string? DelayAction { get; init; }

    /// <summary>
    /// The read-only timestamp of when the <c>delay_action</c> is automatically applied,
    /// in RFC 3339 format.
    /// <para>
    /// Note that this field is calculated by summing the payment's <c>delay_duration</c> and <c>created_at</c>
    /// fields. The <c>created_at</c> field is generated by Square and might not exactly match the
    /// time on your local machine.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delayed_until")]
    public string? DelayedUntil { get; init; }

    /// <summary>
    /// The source type for this payment.
    /// <para>
    /// Current values include <c>CARD</c>, <c>BANK_ACCOUNT</c>, <c>WALLET</c>, <c>BUY_NOW_PAY_LATER</c>, <c>SQUARE_ACCOUNT</c>,
    /// <c>CASH</c> and <c>EXTERNAL</c>. For information about these payment source types,
    /// see <see href="https://developer.squareup.com/docs/payments-api/take-payments">Take Payments</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source_type")]
    [MaxLength(50)]
    public string? SourceType { get; init; }

    /// <summary>
    /// Reflects the current status of a card payment. Contains only non-confidential information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card_details")]
    public CardPaymentDetails? CardDetails { get; init; }

    /// <summary>
    /// Stores details about a cash payment. Contains only non-confidential information. For more information, see
    /// <see href="https://developer.squareup.com/docs/payments-api/take-payments/cash-payments">Take Cash Payments</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash_details")]
    public CashPaymentDetails? CashDetails { get; init; }

    /// <summary>
    /// Additional details about BANK_ACCOUNT type payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_account_details")]
    public BankAccountPaymentDetails? BankAccountDetails { get; init; }

    /// <summary>
    /// Details specific to electronic money payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("electronic_money_details")]
    public ElectronicMoneyDetails? ElectronicMoneyDetails { get; init; }

    /// <summary>
    /// Stores details about an external payment. Contains only non-confidential information.
    /// For more information, see
    /// <see href="https://developer.squareup.com/docs/payments-api/take-payments/external-payments">Take External Payments</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("external_details")]
    public ExternalPaymentDetails? ExternalDetails { get; init; }

    /// <summary>
    /// Additional details about <c>WALLET</c> type payments. Contains only non-confidential information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wallet_details")]
    public DigitalWalletDetails? WalletDetails { get; init; }

    /// <summary>
    /// Additional details about a Buy Now Pay Later payment type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buy_now_pay_later_details")]
    public BuyNowPayLaterDetails? BuyNowPayLaterDetails { get; init; }

    /// <summary>
    /// Additional details about Square Account payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("square_account_details")]
    public SquareAccountDetails? SquareAccountDetails { get; init; }

    /// <summary>
    /// The ID of the location associated with the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    [MaxLength(50)]
    public string? LocationId { get; init; }

    /// <summary>
    /// The ID of the order associated with the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_id")]
    [MaxLength(192)]
    public string? OrderId { get; init; }

    /// <summary>
    /// An optional ID that associates the payment with an entity in
    /// another system.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_id")]
    [MaxLength(40)]
    public string? ReferenceId { get; init; }

    /// <summary>
    /// The ID of the customer associated with the payment. If the ID is
    /// not provided in the <c>CreatePayment</c> request that was used to create the <c>Payment</c>,
    /// Square may use information in the request
    /// (such as the billing and shipping address, email address, and payment source)
    /// to identify a matching customer profile in the Customer Directory.
    /// If found, the profile ID is used. If a profile is not found, the
    /// API attempts to create an
    /// <see href="https://developer.squareup.com/docs/customers-api/what-it-does#instant-profiles">instant profile</see>.
    /// If the API cannot create an
    /// instant profile (either because the seller has disabled it or the
    /// seller's region prevents creating it), this field remains unset. Note that
    /// this process is asynchronous and it may take some time before a
    /// customer ID is added to the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    [MaxLength(191)]
    public string? CustomerId { get; init; }

    /// <summary>
    /// __Deprecated__: Use <c>Payment.team_member_id</c> instead.
    /// <para>
    /// An optional ID of the employee associated with taking the payment.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employee_id")]
    [MaxLength(192)]
    public string? EmployeeId { get; init; }

    /// <summary>
    /// An optional ID of the <see href="entity:TeamMember">TeamMember</see> associated with taking the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member_id")]
    [MaxLength(192)]
    public string? TeamMemberId { get; init; }

    /// <summary>
    /// A list of <c>refund_id</c>s identifying refunds for the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refund_ids")]
    public IReadOnlyList<string>? RefundIds { get; init; }

    /// <summary>
    /// Represents fraud risk information for the associated payment.
    /// <para>
    /// When you take a payment through Square's Payments API (using the <c>CreatePayment</c>
    /// endpoint), Square evaluates it and assigns a risk level to the payment. Sellers
    /// can use this information to determine the course of action (for example,
    /// provide the goods/services or refund the payment).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("risk_evaluation")]
    public RiskEvaluation? RiskEvaluation { get; init; }

    /// <summary>
    /// An optional ID for a Terminal checkout that is associated with the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminal_checkout_id")]
    public string? TerminalCheckoutId { get; init; }

    /// <summary>
    /// The buyer's email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buyer_email_address")]
    [MaxLength(255)]
    public string? BuyerEmailAddress { get; init; }

    /// <summary>
    /// Represents a postal address in a country.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/working-with-addresses">Working with Addresses</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billing_address")]
    public Address? BillingAddress { get; init; }

    /// <summary>
    /// Represents a postal address in a country.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/working-with-addresses">Working with Addresses</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipping_address")]
    public Address? ShippingAddress { get; init; }

    /// <summary>
    /// An optional note to include when creating a payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("note")]
    [MaxLength(500)]
    public string? Note { get; init; }

    /// <summary>
    /// Additional payment information that gets added to the customer's card statement
    /// as part of the statement description.
    /// <para>
    /// Note that the <c>statement_description_identifier</c> might get truncated on the statement description
    /// to fit the required information including the Square identifier (SQ *) and the name of the
    /// seller taking the payment.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statement_description_identifier")]
    public string? StatementDescriptionIdentifier { get; init; }

    /// <summary>
    /// Actions that can be performed on this payment:
    /// - <c>EDIT_AMOUNT_UP</c> - The payment amount can be edited up.
    /// - <c>EDIT_AMOUNT_DOWN</c> - The payment amount can be edited down.
    /// - <c>EDIT_TIP_AMOUNT_UP</c> - The tip amount can be edited up.
    /// - <c>EDIT_TIP_AMOUNT_DOWN</c> - The tip amount can be edited down.
    /// - <c>EDIT_DELAY_ACTION</c> - The delay_action can be edited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("capabilities")]
    public IReadOnlyList<string>? Capabilities { get; init; }

    /// <summary>
    /// The payment's receipt number.
    /// The field is missing if a payment is canceled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("receipt_number")]
    [MaxLength(4)]
    public string? ReceiptNumber { get; init; }

    /// <summary>
    /// The URL for the payment's receipt.
    /// The field is only populated for COMPLETED payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("receipt_url")]
    [MaxLength(255)]
    public string? ReceiptUrl { get; init; }

    /// <summary>
    /// Details about the device that took the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device_details")]
    public DeviceDetails? DeviceDetails { get; init; }

    /// <summary>
    /// Details about the application that took the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("application_details")]
    public ApplicationDetails? ApplicationDetails { get; init; }

    /// <summary>
    /// Whether or not this payment was taken offline.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_offline_payment")]
    public bool? IsOfflinePayment { get; init; }

    /// <summary>
    /// Details specific to offline payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("offline_payment_details")]
    public OfflinePaymentDetails? OfflinePaymentDetails { get; init; }

    /// <summary>
    /// Used for optimistic concurrency. This opaque token identifies a specific version of the
    /// <c>Payment</c> object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version_token")]
    public string? VersionToken { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

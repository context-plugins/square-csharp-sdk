using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Stores information about an invoice. You use the Invoices API to create and manage
/// invoices. For more information, see <see href="https://developer.squareup.com/docs/invoices-api/overview">Invoices API Overview</see>.
/// </summary>
public record Invoice
{
    /// <summary>
    /// The Square-assigned ID of the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The Square-assigned version number, which is incremented each time an update is committed to the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    /// <summary>
    /// The ID of the location that this invoice is associated with.
    /// <para>
    /// If specified in a <c>CreateInvoice</c> request, the value must match the <c>location_id</c> of the associated order.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    [StringLength(255, MinimumLength = 1)]
    public string? LocationId { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:Order">order</see> for which the invoice is created.
    /// This field is required when creating an invoice, and the order must be in the <c>OPEN</c> state.
    /// <para>
    /// To view the line items and other information for the associated order, call the
    /// <see href="api-endpoint:Orders-RetrieveOrder">RetrieveOrder</see> endpoint using the order ID.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_id")]
    [StringLength(255, MinimumLength = 1)]
    public string? OrderId { get; init; }

    /// <summary>
    /// Represents a snapshot of customer data. This object stores customer data that is displayed on the invoice
    /// and that Square uses to deliver the invoice.
    /// <para>
    /// When you provide a customer ID for a draft invoice, Square retrieves the associated customer profile and populates
    /// the remaining <c>InvoiceRecipient</c> fields. You cannot update these fields after the invoice is published.
    /// Square updates the customer ID in response to a merge operation, but does not update other fields.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primary_recipient")]
    public InvoiceRecipient? PrimaryRecipient { get; init; }

    /// <summary>
    /// The payment schedule for the invoice, represented by one or more payment requests that
    /// define payment settings, such as amount due and due date. An invoice supports the following payment request combinations:
    /// - One balance
    /// - One deposit with one balance
    /// - 2–12 installments
    /// - One deposit with 2–12 installments
    /// <para>
    /// This field is required when creating an invoice. It must contain at least one payment request.
    /// All payment requests for the invoice must equal the total order amount. For more information, see
    /// <see href="https://developer.squareup.com/docs/invoices-api/create-publish-invoices#payment-requests">Configuring payment requests</see>.
    /// </para>
    /// <para>
    /// Adding <c>INSTALLMENT</c> payment requests to an invoice requires an
    /// <see href="https://developer.squareup.com/docs/invoices-api/overview#invoices-plus-subscription">Invoices Plus subscription</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_requests")]
    public IReadOnlyList<InvoicePaymentRequest?>? PaymentRequests { get; init; }

    /// <summary>
    /// Indicates how Square delivers the <see href="entity:Invoice">invoice</see> to the customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delivery_method")]
    public InvoiceDeliveryMethod? DeliveryMethod { get; init; }

    /// <summary>
    /// A user-friendly invoice number that is displayed on the invoice. The value is unique within a location.
    /// If not provided when creating an invoice, Square assigns a value.
    /// It increments from 1 and is padded with zeros making it 7 characters long
    /// (for example, 0000001 and 0000002).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoice_number")]
    [StringLength(191, MinimumLength = 1)]
    public string? InvoiceNumber { get; init; }

    /// <summary>
    /// The title of the invoice, which is displayed on the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    [StringLength(255, MinimumLength = 1)]
    public string? Title { get; init; }

    /// <summary>
    /// The description of the invoice, which is displayed on the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [StringLength(65536, MinimumLength = 1)]
    public string? Description { get; init; }

    /// <summary>
    /// The timestamp when the invoice is scheduled for processing, in RFC 3339 format.
    /// After the invoice is published, Square processes the invoice on the specified date,
    /// according to the delivery method and payment request settings.
    /// <para>
    /// If the field is not set, Square processes the invoice immediately after it is published.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheduled_at")]
    public string? ScheduledAt { get; init; }

    /// <summary>
    /// A temporary link to the Square-hosted payment page where the customer can pay the
    /// invoice. If the link expires, customers can provide the email address or phone number
    /// associated with the invoice and request a new link directly from the expired payment page.
    /// <para>
    /// This field is added after the invoice is published and reaches the scheduled date
    /// (if one is defined).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("public_url")]
    public string? PublicUrl { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next_payment_amount_money")]
    public Money? NextPaymentAmountMoney { get; init; }

    /// <summary>
    /// Indicates the status of an <see href="entity:Invoice">invoice</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public InvoiceStatus? Status { get; init; }

    /// <summary>
    /// The time zone used to interpret calendar dates on the invoice, such as <c>due_date</c>.
    /// When an invoice is created, this field is set to the <c>timezone</c> specified for the seller
    /// location. The value cannot be changed.
    /// <para>
    /// For example, a payment <c>due_date</c> of 2021-03-09 with a <c>timezone</c> of America/Los\_Angeles
    /// becomes overdue at midnight on March 9 in America/Los\_Angeles (which equals a UTC timestamp
    /// of 2021-03-10T08:00:00Z).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timezone")]
    public string? Timezone { get; init; }

    /// <summary>
    /// The timestamp when the invoice was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The timestamp when the invoice was last updated, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// The payment methods that customers can use to pay an <see href="entity:Invoice">invoice</see> on the Square-hosted invoice payment page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accepted_payment_methods")]
    public InvoiceAcceptedPaymentMethods? AcceptedPaymentMethods { get; init; }

    /// <summary>
    /// Additional seller-defined fields that are displayed on the invoice. For more information, see
    /// <see href="https://developer.squareup.com/docs/invoices-api/overview#custom-fields">Custom fields</see>.
    /// <para>
    /// Adding custom fields to an invoice requires an
    /// <see href="https://developer.squareup.com/docs/invoices-api/overview#invoices-plus-subscription">Invoices Plus subscription</see>.
    /// </para>
    /// <para>
    /// Max: 2 custom fields
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_fields")]
    public IReadOnlyList<InvoiceCustomField?>? CustomFields { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:Subscription">subscription</see> associated with the invoice.
    /// This field is present only on subscription billing invoices.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription_id")]
    public string? SubscriptionId { get; init; }

    /// <summary>
    /// The date of the sale or the date that the service is rendered, in <c>YYYY-MM-DD</c> format.
    /// This field can be used to specify a past or future date which is displayed on the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sale_or_service_date")]
    public string? SaleOrServiceDate { get; init; }

    /// <summary>
    /// <b>France only.</b> The payment terms and conditions that are displayed on the invoice. For more information,
    /// see <see href="https://developer.squareup.com/docs/invoices-api/overview#payment-conditions">Payment conditions</see>.
    /// <para>
    /// For countries other than France, Square returns an <c>INVALID_REQUEST_ERROR</c> with a <c>BAD_REQUEST</c> code and
    /// "Payment conditions are not supported for this location's country" detail if this field is included in <c>CreateInvoice</c> or <c>UpdateInvoice</c> requests.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_conditions")]
    [StringLength(2000, MinimumLength = 1)]
    public string? PaymentConditions { get; init; }

    /// <summary>
    /// Indicates whether to allow a customer to save a credit or debit card as a card on file or a bank transfer as a
    /// bank account on file. If <c>true</c>, Square displays a __Save my card on file__ or __Save my bank on file__ checkbox on the
    /// invoice payment page. Stored payment information can be used for future automatic payments. The default value is <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("store_payment_method_enabled")]
    public bool? StorePaymentMethodEnabled { get; init; }

    /// <summary>
    /// Metadata about the attachments on the invoice. Invoice attachments are managed using the
    /// <see href="api-endpoint:Invoices-CreateInvoiceAttachment">CreateInvoiceAttachment</see> and <see href="api-endpoint:Invoices-DeleteInvoiceAttachment">DeleteInvoiceAttachment</see> endpoints.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attachments")]
    public IReadOnlyList<InvoiceAttachment>? Attachments { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:TeamMember">team member</see> who created the invoice.
    /// This field is present only on invoices created in the Square Dashboard or Square Invoices app by a logged-in team member.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creator_team_member_id")]
    public string? CreatorTeamMemberId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

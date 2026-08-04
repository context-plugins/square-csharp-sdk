using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Specifies the action for Square to take for processing the invoice. For example,
/// email the invoice, charge a customer's card on file, or do nothing. DEPRECATED at
/// version 2021-01-21. The corresponding <c>request_method</c> field is replaced by the
/// <c>Invoice.delivery_method</c> and <c>InvoicePaymentRequest.automatic_payment_source</c> fields.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvoiceRequestMethod>))]
public sealed record InvoiceRequestMethod : StringEnum<InvoiceRequestMethod>
{
    private InvoiceRequestMethod(string value) : base(value)
    {
    }

    /// <summary>
    /// Directs Square to send invoices, reminders, and receipts to the customer using email.
    /// Square sends the invoice after it is published (either immediately or at the <c>scheduled_at</c>
    /// time, if specified in the <see href="entity:Invoice">invoice</see>).
    /// </summary>
    public static readonly InvoiceRequestMethod Email = new("EMAIL");

    /// <summary>
    /// Directs Square to charge the card on file on the <c>due_date</c> specified in the payment request
    /// and to use email to send invoices, reminders, and receipts.
    /// </summary>
    public static readonly InvoiceRequestMethod ChargeCardOnFile = new("CHARGE_CARD_ON_FILE");

    /// <summary>
    /// Directs Square to take no specific action on the invoice. In this case, the seller
    /// (or the application developer) follows up with the customer for payment. For example,
    /// a seller might collect a payment in the Seller Dashboard or use the Point of Sale (POS) application.
    /// The seller might also share the URL of the Square-hosted invoice page (<c>public_url</c>) with the customer requesting payment.
    /// </summary>
    public static readonly InvoiceRequestMethod ShareManually = new("SHARE_MANUALLY");

    /// <summary>
    /// Directs Square to charge the customer's bank account on file and to use email to send invoices, reminders, and receipts.
    /// The customer must approve the payment.
    /// <para>
    /// The bank on file payment method applies only to invoices that sellers create in the Seller Dashboard or other
    /// Square product. The bank account is provided by the customer during the payment flow. You
    /// cannot set <c>CHARGE_BANK_ON_FILE</c> as a request method using the Invoices API.
    /// </para>
    /// </summary>
    public static readonly InvoiceRequestMethod ChargeBankOnFile = new("CHARGE_BANK_ON_FILE");

    /// <summary>
    /// Directs Square to send invoices and receipts to the customer using SMS (text message). Square sends the invoice
    /// after it is published (either immediately or at the <c>scheduled_at</c> time, if specified in the <see href="entity:Invoice">invoice</see>).
    /// <para>
    /// You cannot set <c>SMS</c> as a request method using the Invoices API.
    /// </para>
    /// </summary>
    public static readonly InvoiceRequestMethod Sms = new("SMS");

    /// <summary>
    /// Directs Square to charge the card on file on the <c>due_date</c> specified in the payment request and to
    /// use SMS (text message) to send invoices and receipts.
    /// <para>
    /// You cannot set <c>SMS_CHARGE_CARD_ON_FILE</c> as a request method using the Invoices API.
    /// </para>
    /// </summary>
    public static readonly InvoiceRequestMethod SmsChargeCardOnFile = new("SMS_CHARGE_CARD_ON_FILE");

    /// <summary>
    /// Directs Square to charge the customer's bank account on file and to use SMS (text message) to send invoices and receipts.
    /// The customer must approve the payment.
    /// <para>
    /// The bank on file payment method applies only to invoices that sellers create in the Seller Dashboard
    /// or other Square product. The bank account is provided by the customer during the payment flow.
    /// You cannot set <c>SMS_CHARGE_BANK_ON_FILE</c> as a request method using the Invoices API.
    /// </para>
    /// </summary>
    public static readonly InvoiceRequestMethod SmsChargeBankOnFile = new("SMS_CHARGE_BANK_ON_FILE");

    public static InvoiceRequestMethod FromValue(string value) => FromValueCore(value);
}

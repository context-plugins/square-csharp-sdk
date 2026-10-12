using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the status of an <see href="entity:Invoice">invoice</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvoiceStatus>))]
public sealed record InvoiceStatus : OpenStringEnum<InvoiceStatus>
{
    private InvoiceStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The invoice is a draft. You must publish a draft invoice before Square can process it.
    /// A draft invoice has no <c>public_url</c>, so it is not available to customers.
    /// </summary>
    public static readonly InvoiceStatus Draft = new("DRAFT");

    /// <summary>
    /// The invoice is published but not yet paid.
    /// </summary>
    public static readonly InvoiceStatus Unpaid = new("UNPAID");

    /// <summary>
    /// The invoice is scheduled to be processed. On the scheduled date,
    /// Square sends the invoice, initiates an automatic payment, or takes no action, depending on
    /// the delivery method and payment request settings. Square also sets the invoice status to the
    /// appropriate state: <c>UNPAID</c>, <c>PAID</c>, <c>PARTIALLY_PAID</c>, or <c>PAYMENT_PENDING</c>.
    /// </summary>
    public static readonly InvoiceStatus Scheduled = new("SCHEDULED");

    /// <summary>
    /// A partial payment is received for the invoice.
    /// </summary>
    public static readonly InvoiceStatus PartiallyPaid = new("PARTIALLY_PAID");

    /// <summary>
    /// The customer paid the invoice in full.
    /// </summary>
    public static readonly InvoiceStatus Paid = new("PAID");

    /// <summary>
    /// The invoice is paid (or partially paid) and some but not all the amount paid is
    /// refunded.
    /// </summary>
    public static readonly InvoiceStatus PartiallyRefunded = new("PARTIALLY_REFUNDED");

    /// <summary>
    /// The full amount that the customer paid for the invoice is refunded.
    /// </summary>
    public static readonly InvoiceStatus Refunded = new("REFUNDED");

    /// <summary>
    /// The invoice is canceled. Square no longer requests payments from the customer.
    /// The Square-hosted payment page is still accessible using the temporary <c>public_url</c>
    /// link, but the invoice is shown as canceled and does not accept payment.
    /// </summary>
    public static readonly InvoiceStatus Canceled = new("CANCELED");

    /// <summary>
    /// Square canceled the invoice due to suspicious activity.
    /// </summary>
    public static readonly InvoiceStatus Failed = new("FAILED");

    /// <summary>
    /// A payment on the invoice was initiated but has not yet been processed.
    /// <para>
    /// When in this state, invoices cannot be updated and other payments cannot be initiated.
    /// </para>
    /// </summary>
    public static readonly InvoiceStatus PaymentPending = new("PAYMENT_PENDING");

    public TResult Match<TResult>(Func<TResult> onDraft,
        Func<TResult> onUnpaid,
        Func<TResult> onScheduled,
        Func<TResult> onPartiallyPaid,
        Func<TResult> onPaid,
        Func<TResult> onPartiallyRefunded,
        Func<TResult> onRefunded,
        Func<TResult> onCanceled,
        Func<TResult> onFailed,
        Func<TResult> onPaymentPending,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Draft => onDraft(),
            _ when this == Unpaid => onUnpaid(),
            _ when this == Scheduled => onScheduled(),
            _ when this == PartiallyPaid => onPartiallyPaid(),
            _ when this == Paid => onPaid(),
            _ when this == PartiallyRefunded => onPartiallyRefunded(),
            _ when this == Refunded => onRefunded(),
            _ when this == Canceled => onCanceled(),
            _ when this == Failed => onFailed(),
            _ when this == PaymentPending => onPaymentPending(),
            _ => otherwise(Value)
        };

    public void Match(Action onDraft,
        Action onUnpaid,
        Action onScheduled,
        Action onPartiallyPaid,
        Action onPaid,
        Action onPartiallyRefunded,
        Action onRefunded,
        Action onCanceled,
        Action onFailed,
        Action onPaymentPending,
        Action<string> otherwise)
    {
        if (this == Draft) onDraft();
        else if (this == Unpaid) onUnpaid();
        else if (this == Scheduled) onScheduled();
        else if (this == PartiallyPaid) onPartiallyPaid();
        else if (this == Paid) onPaid();
        else if (this == PartiallyRefunded) onPartiallyRefunded();
        else if (this == Refunded) onRefunded();
        else if (this == Canceled) onCanceled();
        else if (this == Failed) onFailed();
        else if (this == PaymentPending) onPaymentPending();
        else otherwise(Value);
    }
}

using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates how Square delivers the <see href="entity:Invoice">invoice</see> to the customer.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvoiceDeliveryMethod>))]
public sealed record InvoiceDeliveryMethod : OpenStringEnum<InvoiceDeliveryMethod>
{
    private InvoiceDeliveryMethod(string value) : base(value)
    {
    }

    /// <summary>
    /// Directs Square to send invoices, reminders, and receipts to the customer using email.
    /// </summary>
    public static readonly InvoiceDeliveryMethod Email = new("EMAIL");

    /// <summary>
    /// Directs Square to take no action on the invoice. In this case, the seller
    /// or application developer follows up with the customer for payment. For example,
    /// a seller might collect a payment in the Seller Dashboard or Point of Sale (POS) application.
    /// The seller might also share the URL of the Square-hosted invoice page (<c>public_url</c>) with the customer to request payment.
    /// </summary>
    public static readonly InvoiceDeliveryMethod ShareManually = new("SHARE_MANUALLY");

    /// <summary>
    /// Directs Square to send invoices and receipts to the customer using SMS (text message).
    /// <para>
    /// You cannot set <c>SMS</c> as a delivery method using the Invoices API, but you can change an <c>SMS</c> delivery method to <c>EMAIL</c> or <c>SHARE_MANUALLY</c>.
    /// </para>
    /// </summary>
    public static readonly InvoiceDeliveryMethod Sms = new("SMS");

    public TResult Match<TResult>(Func<TResult> onEmail,
        Func<TResult> onShareManually,
        Func<TResult> onSms,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Email => onEmail(),
            _ when this == ShareManually => onShareManually(),
            _ when this == Sms => onSms(),
            _ => otherwise(Value)
        };

    public void Match(Action onEmail, Action onShareManually, Action onSms, Action<string> otherwise)
    {
        if (this == Email) onEmail();
        else if (this == ShareManually) onShareManually();
        else if (this == Sms) onSms();
        else otherwise(Value);
    }
}

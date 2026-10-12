using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The status of a payment request reminder.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvoicePaymentReminderStatus>))]
public sealed record InvoicePaymentReminderStatus : OpenStringEnum<InvoicePaymentReminderStatus>
{
    private InvoicePaymentReminderStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The reminder will be sent on the <c>relative_scheduled_date</c> (if the invoice is published).
    /// </summary>
    public static readonly InvoicePaymentReminderStatus Pending = new("PENDING");

    /// <summary>
    /// The reminder is not applicable and is not sent. The following are examples
    /// of when reminders are not applicable and are not sent:
    /// - You schedule a reminder to be sent before the invoice is published.
    /// - The invoice is configured with multiple payment requests and a payment request reminder
    /// is configured to be sent after the next payment request <c>due_date</c>.
    /// - Two reminders (for different payment requests) are configured to be sent on the
    /// same date. Therefore, only one reminder is sent.
    /// - You configure a reminder to be sent on the date that the invoice is scheduled to be sent.
    /// - The payment request is already paid.
    /// - The invoice status is <c>CANCELED</c> or <c>FAILED</c>.
    /// </summary>
    public static readonly InvoicePaymentReminderStatus NotApplicable = new("NOT_APPLICABLE");

    /// <summary>
    /// The reminder is sent.
    /// </summary>
    public static readonly InvoicePaymentReminderStatus Sent = new("SENT");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onNotApplicable,
        Func<TResult> onSent,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == NotApplicable => onNotApplicable(),
            _ when this == Sent => onSent(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending, Action onNotApplicable, Action onSent, Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == NotApplicable) onNotApplicable();
        else if (this == Sent) onSent();
        else otherwise(Value);
    }
}

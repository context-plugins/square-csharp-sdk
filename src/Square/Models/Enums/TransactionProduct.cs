using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the Square product used to process a transaction.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionProduct>))]
public sealed record TransactionProduct : OpenStringEnum<TransactionProduct>
{
    private TransactionProduct(string value) : base(value)
    {
    }

    /// <summary>
    /// Square Point of Sale.
    /// </summary>
    public static readonly TransactionProduct Register = new("REGISTER");

    /// <summary>
    /// The Square Connect API.
    /// </summary>
    public static readonly TransactionProduct ExternalApi = new("EXTERNAL_API");

    /// <summary>
    /// A Square subscription for one of multiple products.
    /// </summary>
    public static readonly TransactionProduct Billing = new("BILLING");

    /// <summary>
    /// Square Appointments.
    /// </summary>
    public static readonly TransactionProduct Appointments = new("APPOINTMENTS");

    /// <summary>
    /// Square Invoices.
    /// </summary>
    public static readonly TransactionProduct Invoices = new("INVOICES");

    /// <summary>
    /// Square Online Store.
    /// </summary>
    public static readonly TransactionProduct OnlineStore = new("ONLINE_STORE");

    /// <summary>
    /// Square Payroll.
    /// </summary>
    public static readonly TransactionProduct Payroll = new("PAYROLL");

    /// <summary>
    /// A Square product that does not match any other value.
    /// </summary>
    public static readonly TransactionProduct Other = new("OTHER");

    public TResult Match<TResult>(Func<TResult> onRegister,
        Func<TResult> onExternalApi,
        Func<TResult> onBilling,
        Func<TResult> onAppointments,
        Func<TResult> onInvoices,
        Func<TResult> onOnlineStore,
        Func<TResult> onPayroll,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Register => onRegister(),
            _ when this == ExternalApi => onExternalApi(),
            _ when this == Billing => onBilling(),
            _ when this == Appointments => onAppointments(),
            _ when this == Invoices => onInvoices(),
            _ when this == OnlineStore => onOnlineStore(),
            _ when this == Payroll => onPayroll(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onRegister,
        Action onExternalApi,
        Action onBilling,
        Action onAppointments,
        Action onInvoices,
        Action onOnlineStore,
        Action onPayroll,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == Register) onRegister();
        else if (this == ExternalApi) onExternalApi();
        else if (this == Billing) onBilling();
        else if (this == Appointments) onAppointments();
        else if (this == Invoices) onInvoices();
        else if (this == OnlineStore) onOnlineStore();
        else if (this == Payroll) onPayroll();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}

using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the Square product used to generate a change.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Product>))]
public sealed record Product : OpenStringEnum<Product>
{
    private Product(string value) : base(value)
    {
    }

    /// <summary>
    /// Square Point of Sale application.
    /// </summary>
    public static readonly Product SquarePos = new("SQUARE_POS");

    /// <summary>
    /// Square Connect APIs (for example, Orders API or Checkout API).
    /// </summary>
    public static readonly Product ExternalApi = new("EXTERNAL_API");

    /// <summary>
    /// A Square subscription (various products).
    /// </summary>
    public static readonly Product Billing = new("BILLING");

    /// <summary>
    /// Square Appointments.
    /// </summary>
    public static readonly Product Appointments = new("APPOINTMENTS");

    /// <summary>
    /// Square Invoices.
    /// </summary>
    public static readonly Product Invoices = new("INVOICES");

    /// <summary>
    /// Square Online Store.
    /// </summary>
    public static readonly Product OnlineStore = new("ONLINE_STORE");

    /// <summary>
    /// Square Payroll.
    /// </summary>
    public static readonly Product Payroll = new("PAYROLL");

    /// <summary>
    /// Square Dashboard.
    /// </summary>
    public static readonly Product Dashboard = new("DASHBOARD");

    /// <summary>
    /// Item Library Import.
    /// </summary>
    public static readonly Product ItemLibraryImport = new("ITEM_LIBRARY_IMPORT");

    /// <summary>
    /// A Square product that does not match any other value.
    /// </summary>
    public static readonly Product Other = new("OTHER");

    public TResult Match<TResult>(Func<TResult> onSquarePos,
        Func<TResult> onExternalApi,
        Func<TResult> onBilling,
        Func<TResult> onAppointments,
        Func<TResult> onInvoices,
        Func<TResult> onOnlineStore,
        Func<TResult> onPayroll,
        Func<TResult> onDashboard,
        Func<TResult> onItemLibraryImport,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SquarePos => onSquarePos(),
            _ when this == ExternalApi => onExternalApi(),
            _ when this == Billing => onBilling(),
            _ when this == Appointments => onAppointments(),
            _ when this == Invoices => onInvoices(),
            _ when this == OnlineStore => onOnlineStore(),
            _ when this == Payroll => onPayroll(),
            _ when this == Dashboard => onDashboard(),
            _ when this == ItemLibraryImport => onItemLibraryImport(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onSquarePos,
        Action onExternalApi,
        Action onBilling,
        Action onAppointments,
        Action onInvoices,
        Action onOnlineStore,
        Action onPayroll,
        Action onDashboard,
        Action onItemLibraryImport,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == SquarePos) onSquarePos();
        else if (this == ExternalApi) onExternalApi();
        else if (this == Billing) onBilling();
        else if (this == Appointments) onAppointments();
        else if (this == Invoices) onInvoices();
        else if (this == OnlineStore) onOnlineStore();
        else if (this == Payroll) onPayroll();
        else if (this == Dashboard) onDashboard();
        else if (this == ItemLibraryImport) onItemLibraryImport();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}

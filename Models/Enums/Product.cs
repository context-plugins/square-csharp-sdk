using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the Square product used to generate a change.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Product>))]
public sealed record Product : StringEnum<Product>
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

    public static Product FromValue(string value) => FromValueCore(value);
}

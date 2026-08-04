using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// A list of products to return to external callers.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ApplicationDetailsExternalSquareProduct>))]
public sealed record ApplicationDetailsExternalSquareProduct : StringEnum<ApplicationDetailsExternalSquareProduct>
{
    private ApplicationDetailsExternalSquareProduct(string value) : base(value)
    {
    }

    public static readonly ApplicationDetailsExternalSquareProduct Appointments = new("APPOINTMENTS");

    public static readonly ApplicationDetailsExternalSquareProduct EcommerceApi = new("ECOMMERCE_API");

    public static readonly ApplicationDetailsExternalSquareProduct Invoices = new("INVOICES");

    public static readonly ApplicationDetailsExternalSquareProduct OnlineStore = new("ONLINE_STORE");

    public static readonly ApplicationDetailsExternalSquareProduct Other = new("OTHER");

    public static readonly ApplicationDetailsExternalSquareProduct Restaurants = new("RESTAURANTS");

    public static readonly ApplicationDetailsExternalSquareProduct Retail = new("RETAIL");

    public static readonly ApplicationDetailsExternalSquareProduct SquarePos = new("SQUARE_POS");

    public static readonly ApplicationDetailsExternalSquareProduct TerminalApi = new("TERMINAL_API");

    public static readonly ApplicationDetailsExternalSquareProduct VirtualTerminal = new("VIRTUAL_TERMINAL");

    public static ApplicationDetailsExternalSquareProduct FromValue(string value) => FromValueCore(value);
}

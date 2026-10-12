using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// A list of products to return to external callers.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ApplicationDetailsExternalSquareProduct>))]
public sealed record ApplicationDetailsExternalSquareProduct : OpenStringEnum<ApplicationDetailsExternalSquareProduct>
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

    public TResult Match<TResult>(Func<TResult> onAppointments,
        Func<TResult> onEcommerceApi,
        Func<TResult> onInvoices,
        Func<TResult> onOnlineStore,
        Func<TResult> onOther,
        Func<TResult> onRestaurants,
        Func<TResult> onRetail,
        Func<TResult> onSquarePos,
        Func<TResult> onTerminalApi,
        Func<TResult> onVirtualTerminal,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Appointments => onAppointments(),
            _ when this == EcommerceApi => onEcommerceApi(),
            _ when this == Invoices => onInvoices(),
            _ when this == OnlineStore => onOnlineStore(),
            _ when this == Other => onOther(),
            _ when this == Restaurants => onRestaurants(),
            _ when this == Retail => onRetail(),
            _ when this == SquarePos => onSquarePos(),
            _ when this == TerminalApi => onTerminalApi(),
            _ when this == VirtualTerminal => onVirtualTerminal(),
            _ => otherwise(Value)
        };

    public void Match(Action onAppointments,
        Action onEcommerceApi,
        Action onInvoices,
        Action onOnlineStore,
        Action onOther,
        Action onRestaurants,
        Action onRetail,
        Action onSquarePos,
        Action onTerminalApi,
        Action onVirtualTerminal,
        Action<string> otherwise)
    {
        if (this == Appointments) onAppointments();
        else if (this == EcommerceApi) onEcommerceApi();
        else if (this == Invoices) onInvoices();
        else if (this == OnlineStore) onOnlineStore();
        else if (this == Other) onOther();
        else if (this == Restaurants) onRestaurants();
        else if (this == Retail) onRetail();
        else if (this == SquarePos) onSquarePos();
        else if (this == TerminalApi) onTerminalApi();
        else if (this == VirtualTerminal) onVirtualTerminal();
        else otherwise(Value);
    }
}

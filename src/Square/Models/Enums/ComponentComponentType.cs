using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// An enum for ComponentType.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ComponentComponentType>))]
public sealed record ComponentComponentType : OpenStringEnum<ComponentComponentType>
{
    private ComponentComponentType(string value) : base(value)
    {
    }

    public static readonly ComponentComponentType Application = new("APPLICATION");

    public static readonly ComponentComponentType CardReader = new("CARD_READER");

    public static readonly ComponentComponentType Battery = new("BATTERY");

    public static readonly ComponentComponentType Wifi = new("WIFI");

    public static readonly ComponentComponentType Ethernet = new("ETHERNET");

    public static readonly ComponentComponentType Printer = new("PRINTER");

    public TResult Match<TResult>(Func<TResult> onApplication,
        Func<TResult> onCardReader,
        Func<TResult> onBattery,
        Func<TResult> onWifi,
        Func<TResult> onEthernet,
        Func<TResult> onPrinter,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Application => onApplication(),
            _ when this == CardReader => onCardReader(),
            _ when this == Battery => onBattery(),
            _ when this == Wifi => onWifi(),
            _ when this == Ethernet => onEthernet(),
            _ when this == Printer => onPrinter(),
            _ => otherwise(Value)
        };

    public void Match(Action onApplication,
        Action onCardReader,
        Action onBattery,
        Action onWifi,
        Action onEthernet,
        Action onPrinter,
        Action<string> otherwise)
    {
        if (this == Application) onApplication();
        else if (this == CardReader) onCardReader();
        else if (this == Battery) onBattery();
        else if (this == Wifi) onWifi();
        else if (this == Ethernet) onEthernet();
        else if (this == Printer) onPrinter();
        else otherwise(Value);
    }
}

using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// An enum for ComponentType.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ComponentComponentType>))]
public sealed record ComponentComponentType : StringEnum<ComponentComponentType>
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

    public static ComponentComponentType FromValue(string value) => FromValueCore(value);
}

using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Servers;

[JsonConverter(typeof(StringEnumConverter<ServerEnvironment>))]
public record ServerEnvironment : StringEnum<ServerEnvironment>
{
    public static readonly ServerEnvironment Production = new("production");
    public static readonly ServerEnvironment Sandbox = new("sandbox");
    public static readonly ServerEnvironment Custom = new("custom");

    private ServerEnvironment(string value) : base(value)
    {
    }

    internal T Match<T>(Func<T> onProduction, Func<T> onSandbox, Func<T> onCustom) =>
        this switch
        {
            _ when this == Production => onProduction(),
            _ when this == Sandbox => onSandbox(),
            _ when this == Custom => onCustom(),
            _ => throw new ArgumentOutOfRangeException(nameof(ServerEnvironment),
                this,
                $"Unknown {nameof(ServerEnvironment)} value.")
        };

    public static ServerEnvironment Default() => Production;
}

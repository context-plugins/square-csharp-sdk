using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ProductType>))]
public sealed record ProductType : OpenStringEnum<ProductType>
{
    private ProductType(string value) : base(value)
    {
    }

    public static readonly ProductType TerminalApi = new("TERMINAL_API");

    public TResult Match<TResult>(Func<TResult> onTerminalApi, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == TerminalApi => onTerminalApi(),
            _ => otherwise(Value)
        };

    public void Match(Action onTerminalApi, Action<string> otherwise)
    {
        if (this == TerminalApi) onTerminalApi();
        else otherwise(Value);
    }
}

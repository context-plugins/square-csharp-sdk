using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ApplicationType>))]
public sealed record ApplicationType : OpenStringEnum<ApplicationType>
{
    private ApplicationType(string value) : base(value)
    {
    }

    public static readonly ApplicationType TerminalApi = new("TERMINAL_API");

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

using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ListChannelsRequestConstants>))]
public sealed record ListChannelsRequestConstants : OpenStringEnum<ListChannelsRequestConstants>
{
    private ListChannelsRequestConstants(string value) : base(value)
    {
    }

    public static readonly ListChannelsRequestConstants MaxPageSize = new("MAX_PAGE_SIZE");

    public TResult Match<TResult>(Func<TResult> onMaxPageSize, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MaxPageSize => onMaxPageSize(),
            _ => otherwise(Value)
        };

    public void Match(Action onMaxPageSize, Action<string> otherwise)
    {
        if (this == MaxPageSize) onMaxPageSize();
        else otherwise(Value);
    }
}

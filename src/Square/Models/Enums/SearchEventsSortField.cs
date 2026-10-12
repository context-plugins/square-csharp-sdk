using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Specifies the sort key for events returned from a search.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SearchEventsSortField>))]
public sealed record SearchEventsSortField : OpenStringEnum<SearchEventsSortField>
{
    private SearchEventsSortField(string value) : base(value)
    {
    }

    /// <summary>
    /// Use the default sort key. The default behavior is to sort events by when they were created (<c>created_at</c>).
    /// </summary>
    public static readonly SearchEventsSortField Default = new("DEFAULT");

    public TResult Match<TResult>(Func<TResult> onDefault, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Default => onDefault(),
            _ => otherwise(Value)
        };

    public void Match(Action onDefault, Action<string> otherwise)
    {
        if (this == Default) onDefault();
        else otherwise(Value);
    }
}

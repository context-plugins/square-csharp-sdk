using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The order (e.g., chronological or alphabetical) in which results from a request are returned.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SortOrder>))]
public sealed record SortOrder : OpenStringEnum<SortOrder>
{
    private SortOrder(string value) : base(value)
    {
    }

    /// <summary>
    /// The results are returned in descending (e.g., newest-first or Z-A) order.
    /// </summary>
    public static readonly SortOrder Desc = new("DESC");

    /// <summary>
    /// The results are returned in ascending (e.g., oldest-first or A-Z) order.
    /// </summary>
    public static readonly SortOrder Asc = new("ASC");

    public TResult Match<TResult>(Func<TResult> onDesc, Func<TResult> onAsc, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Desc => onDesc(),
            _ when this == Asc => onAsc(),
            _ => otherwise(Value)
        };

    public void Match(Action onDesc, Action onAsc, Action<string> otherwise)
    {
        if (this == Desc) onDesc();
        else if (this == Asc) onAsc();
        else otherwise(Value);
    }
}

using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Specifies the sort key for events returned from a search.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SearchEventsSortField>))]
public sealed record SearchEventsSortField : StringEnum<SearchEventsSortField>
{
    private SearchEventsSortField(string value) : base(value)
    {
    }

    /// <summary>
    /// Use the default sort key. The default behavior is to sort events by when they were created (<c>created_at</c>).
    /// </summary>
    public static readonly SearchEventsSortField Default = new("DEFAULT");

    public static SearchEventsSortField FromValue(string value) => FromValueCore(value);
}

using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Enumeration of visibility-filter values used to set the ability to view custom attributes or custom attribute definitions.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VisibilityFilter>))]
public sealed record VisibilityFilter : OpenStringEnum<VisibilityFilter>
{
    private VisibilityFilter(string value) : base(value)
    {
    }

    /// <summary>
    /// All custom attributes or custom attribute definitions.
    /// </summary>
    public static readonly VisibilityFilter All = new("ALL");

    /// <summary>
    /// All custom attributes or custom attribute definitions with the <c>visibility</c> field set to <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </summary>
    public static readonly VisibilityFilter Read = new("READ");

    /// <summary>
    /// All custom attributes or custom attribute definitions with the <c>visibility</c> field set to <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </summary>
    public static readonly VisibilityFilter ReadWrite = new("READ_WRITE");

    public TResult Match<TResult>(Func<TResult> onAll,
        Func<TResult> onRead,
        Func<TResult> onReadWrite,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == All => onAll(),
            _ when this == Read => onRead(),
            _ when this == ReadWrite => onReadWrite(),
            _ => otherwise(Value)
        };

    public void Match(Action onAll, Action onRead, Action onReadWrite, Action<string> otherwise)
    {
        if (this == All) onAll();
        else if (this == Read) onRead();
        else if (this == ReadWrite) onReadWrite();
        else otherwise(Value);
    }
}

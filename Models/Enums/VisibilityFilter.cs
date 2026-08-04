using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Enumeration of visibility-filter values used to set the ability to view custom attributes or custom attribute definitions.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VisibilityFilter>))]
public sealed record VisibilityFilter : StringEnum<VisibilityFilter>
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

    public static VisibilityFilter FromValue(string value) => FromValueCore(value);
}

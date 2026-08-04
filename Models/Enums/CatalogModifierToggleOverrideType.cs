using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Item level overrides for bool attributes
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogModifierToggleOverrideType>))]
public sealed record CatalogModifierToggleOverrideType : StringEnum<CatalogModifierToggleOverrideType>
{
    private CatalogModifierToggleOverrideType(string value) : base(value)
    {
    }

    /// <summary>
    /// False override
    /// </summary>
    public static readonly CatalogModifierToggleOverrideType No = new("NO");

    /// <summary>
    /// True override
    /// </summary>
    public static readonly CatalogModifierToggleOverrideType Yes = new("YES");

    /// <summary>
    /// No override
    /// </summary>
    public static readonly CatalogModifierToggleOverrideType NotSet = new("NOT_SET");

    public static CatalogModifierToggleOverrideType FromValue(string value) => FromValueCore(value);
}

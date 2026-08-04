using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Defines the type of <c>CatalogModifierList</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogModifierListModifierType>))]
public sealed record CatalogModifierListModifierType : StringEnum<CatalogModifierListModifierType>
{
    private CatalogModifierListModifierType(string value) : base(value)
    {
    }

    /// <summary>
    /// The <c>CatalogModifierList</c> instance is a non-empty list of non text-based modifiers.
    /// </summary>
    public static readonly CatalogModifierListModifierType List = new("LIST");

    /// <summary>
    /// The <c>CatalogModifierList</c> instance is a single text-based modifier.
    /// </summary>
    public static readonly CatalogModifierListModifierType Text = new("TEXT");

    public static CatalogModifierListModifierType FromValue(string value) => FromValueCore(value);
}

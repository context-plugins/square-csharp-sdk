using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates whether a CatalogModifierList supports multiple selections.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogModifierListSelectionType>))]
public sealed record CatalogModifierListSelectionType : OpenStringEnum<CatalogModifierListSelectionType>
{
    private CatalogModifierListSelectionType(string value) : base(value)
    {
    }

    /// <summary>
    /// Indicates that a CatalogModifierList allows only a
    /// single CatalogModifier to be selected.
    /// </summary>
    public static readonly CatalogModifierListSelectionType Single = new("SINGLE");

    /// <summary>
    /// Indicates that a CatalogModifierList allows multiple
    /// CatalogModifier to be selected.
    /// </summary>
    public static readonly CatalogModifierListSelectionType Multiple = new("MULTIPLE");

    public TResult Match<TResult>(Func<TResult> onSingle, Func<TResult> onMultiple, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Single => onSingle(),
            _ when this == Multiple => onMultiple(),
            _ => otherwise(Value)
        };

    public void Match(Action onSingle, Action onMultiple, Action<string> otherwise)
    {
        if (this == Single) onSingle();
        else if (this == Multiple) onMultiple();
        else otherwise(Value);
    }
}

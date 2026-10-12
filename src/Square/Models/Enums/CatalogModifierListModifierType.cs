using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Defines the type of <c>CatalogModifierList</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogModifierListModifierType>))]
public sealed record CatalogModifierListModifierType : OpenStringEnum<CatalogModifierListModifierType>
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

    public TResult Match<TResult>(Func<TResult> onList, Func<TResult> onText, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == List => onList(),
            _ when this == Text => onText(),
            _ => otherwise(Value)
        };

    public void Match(Action onList, Action onText, Action<string> otherwise)
    {
        if (this == List) onList();
        else if (this == Text) onText();
        else otherwise(Value);
    }
}

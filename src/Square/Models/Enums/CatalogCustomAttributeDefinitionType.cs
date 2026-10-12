using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Defines the possible types for a custom attribute.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogCustomAttributeDefinitionType>))]
public sealed record CatalogCustomAttributeDefinitionType : OpenStringEnum<CatalogCustomAttributeDefinitionType>
{
    private CatalogCustomAttributeDefinitionType(string value) : base(value)
    {
    }

    /// <summary>
    /// A free-form string containing up to 255 characters.
    /// </summary>
    public static readonly CatalogCustomAttributeDefinitionType String = new("STRING");

    /// <summary>
    /// A <c>true</c> or <c>false</c> value.
    /// </summary>
    public static readonly CatalogCustomAttributeDefinitionType Boolean = new("BOOLEAN");

    /// <summary>
    /// A decimal string representation of a number. Can support up to 5 digits after the decimal point.
    /// </summary>
    public static readonly CatalogCustomAttributeDefinitionType Number = new("NUMBER");

    /// <summary>
    /// One or more choices from <c>allowed_selections</c>.
    /// </summary>
    public static readonly CatalogCustomAttributeDefinitionType Selection = new("SELECTION");

    public TResult Match<TResult>(Func<TResult> onString,
        Func<TResult> onBoolean,
        Func<TResult> onNumber,
        Func<TResult> onSelection,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == String => onString(),
            _ when this == Boolean => onBoolean(),
            _ when this == Number => onNumber(),
            _ when this == Selection => onSelection(),
            _ => otherwise(Value)
        };

    public void Match(Action onString, Action onBoolean, Action onNumber, Action onSelection, Action<string> otherwise)
    {
        if (this == String) onString();
        else if (this == Boolean) onBoolean();
        else if (this == Number) onNumber();
        else if (this == Selection) onSelection();
        else otherwise(Value);
    }
}

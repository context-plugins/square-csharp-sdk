using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Defines the visibility of a custom attribute to applications other than their
/// creating application.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogCustomAttributeDefinitionAppVisibility>))]
public sealed record CatalogCustomAttributeDefinitionAppVisibility : OpenStringEnum<CatalogCustomAttributeDefinitionAppVisibility>
{
    private CatalogCustomAttributeDefinitionAppVisibility(string value) : base(value)
    {
    }

    /// <summary>
    /// Other applications cannot read this custom attribute.
    /// </summary>
    public static readonly CatalogCustomAttributeDefinitionAppVisibility AppVisibilityHidden = new(
        "APP_VISIBILITY_HIDDEN");

    /// <summary>
    /// Other applications can read this custom attribute definition and
    /// values.
    /// </summary>
    public static readonly CatalogCustomAttributeDefinitionAppVisibility AppVisibilityReadOnly = new(
        "APP_VISIBILITY_READ_ONLY");

    /// <summary>
    /// Other applications can read and write custom attribute values on objects.
    /// They can read but cannot edit the custom attribute definition.
    /// </summary>
    public static readonly CatalogCustomAttributeDefinitionAppVisibility AppVisibilityReadWriteValues = new(
        "APP_VISIBILITY_READ_WRITE_VALUES");

    public TResult Match<TResult>(Func<TResult> onAppVisibilityHidden,
        Func<TResult> onAppVisibilityReadOnly,
        Func<TResult> onAppVisibilityReadWriteValues,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AppVisibilityHidden => onAppVisibilityHidden(),
            _ when this == AppVisibilityReadOnly => onAppVisibilityReadOnly(),
            _ when this == AppVisibilityReadWriteValues => onAppVisibilityReadWriteValues(),
            _ => otherwise(Value)
        };

    public void Match(Action onAppVisibilityHidden,
        Action onAppVisibilityReadOnly,
        Action onAppVisibilityReadWriteValues,
        Action<string> otherwise)
    {
        if (this == AppVisibilityHidden) onAppVisibilityHidden();
        else if (this == AppVisibilityReadOnly) onAppVisibilityReadOnly();
        else if (this == AppVisibilityReadWriteValues) onAppVisibilityReadWriteValues();
        else otherwise(Value);
    }
}

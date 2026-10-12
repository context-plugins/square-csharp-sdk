using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The level of permission that a seller or other applications requires to
/// view this custom attribute definition.
/// The <c>Visibility</c> field controls who can read and write the custom attribute values
/// and custom attribute definition.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CustomAttributeDefinitionVisibility>))]
public sealed record CustomAttributeDefinitionVisibility : OpenStringEnum<CustomAttributeDefinitionVisibility>
{
    private CustomAttributeDefinitionVisibility(string value) : base(value)
    {
    }

    /// <summary>
    /// The custom attribute definition and values are hidden from the seller (except on export
    /// of all seller data) and other developers.
    /// </summary>
    public static readonly CustomAttributeDefinitionVisibility VisibilityHidden = new("VISIBILITY_HIDDEN");

    /// <summary>
    /// The seller and other developers can read the custom attribute definition and values
    /// on resources.
    /// </summary>
    public static readonly CustomAttributeDefinitionVisibility VisibilityReadOnly = new("VISIBILITY_READ_ONLY");

    /// <summary>
    /// The seller and other developers can read the custom attribute definition,
    /// and can read and write values on resources. A custom attribute definition
    /// can only be edited or deleted by the application that created it.
    /// </summary>
    public static readonly CustomAttributeDefinitionVisibility VisibilityReadWriteValues = new(
        "VISIBILITY_READ_WRITE_VALUES");

    public TResult Match<TResult>(Func<TResult> onVisibilityHidden,
        Func<TResult> onVisibilityReadOnly,
        Func<TResult> onVisibilityReadWriteValues,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == VisibilityHidden => onVisibilityHidden(),
            _ when this == VisibilityReadOnly => onVisibilityReadOnly(),
            _ when this == VisibilityReadWriteValues => onVisibilityReadWriteValues(),
            _ => otherwise(Value)
        };

    public void Match(Action onVisibilityHidden,
        Action onVisibilityReadOnly,
        Action onVisibilityReadWriteValues,
        Action<string> otherwise)
    {
        if (this == VisibilityHidden) onVisibilityHidden();
        else if (this == VisibilityReadOnly) onVisibilityReadOnly();
        else if (this == VisibilityReadWriteValues) onVisibilityReadWriteValues();
        else otherwise(Value);
    }
}

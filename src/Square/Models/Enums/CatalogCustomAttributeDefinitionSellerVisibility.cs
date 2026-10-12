using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Defines the visibility of a custom attribute to sellers in Square
/// client applications, Square APIs or in Square UIs (including Square Point
/// of Sale applications and Square Dashboard).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogCustomAttributeDefinitionSellerVisibility>))]
public sealed record CatalogCustomAttributeDefinitionSellerVisibility : OpenStringEnum<CatalogCustomAttributeDefinitionSellerVisibility>
{
    private CatalogCustomAttributeDefinitionSellerVisibility(string value) : base(value)
    {
    }

    /// <summary>
    /// Sellers cannot read this custom attribute in Square client
    /// applications or Square APIs.
    /// </summary>
    public static readonly CatalogCustomAttributeDefinitionSellerVisibility SellerVisibilityHidden = new(
        "SELLER_VISIBILITY_HIDDEN");

    /// <summary>
    /// Sellers can read and write this custom attribute value in catalog objects,
    /// but cannot edit the custom attribute definition.
    /// </summary>
    public static readonly CatalogCustomAttributeDefinitionSellerVisibility SellerVisibilityReadWriteValues = new(
        "SELLER_VISIBILITY_READ_WRITE_VALUES");

    public TResult Match<TResult>(Func<TResult> onSellerVisibilityHidden,
        Func<TResult> onSellerVisibilityReadWriteValues,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SellerVisibilityHidden => onSellerVisibilityHidden(),
            _ when this == SellerVisibilityReadWriteValues => onSellerVisibilityReadWriteValues(),
            _ => otherwise(Value)
        };

    public void Match(Action onSellerVisibilityHidden,
        Action onSellerVisibilityReadWriteValues,
        Action<string> otherwise)
    {
        if (this == SellerVisibilityHidden) onSellerVisibilityHidden();
        else if (this == SellerVisibilityReadWriteValues) onSellerVisibilityReadWriteValues();
        else otherwise(Value);
    }
}

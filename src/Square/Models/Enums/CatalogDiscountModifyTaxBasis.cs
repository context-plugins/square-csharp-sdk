using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<CatalogDiscountModifyTaxBasis>))]
public sealed record CatalogDiscountModifyTaxBasis : OpenStringEnum<CatalogDiscountModifyTaxBasis>
{
    private CatalogDiscountModifyTaxBasis(string value) : base(value)
    {
    }

    /// <summary>
    /// Application of the discount will modify the tax basis.
    /// </summary>
    public static readonly CatalogDiscountModifyTaxBasis ModifyTaxBasis = new("MODIFY_TAX_BASIS");

    /// <summary>
    /// Application of the discount will not modify the tax basis.
    /// </summary>
    public static readonly CatalogDiscountModifyTaxBasis DoNotModifyTaxBasis = new("DO_NOT_MODIFY_TAX_BASIS");

    public TResult Match<TResult>(Func<TResult> onModifyTaxBasis,
        Func<TResult> onDoNotModifyTaxBasis,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ModifyTaxBasis => onModifyTaxBasis(),
            _ when this == DoNotModifyTaxBasis => onDoNotModifyTaxBasis(),
            _ => otherwise(Value)
        };

    public void Match(Action onModifyTaxBasis, Action onDoNotModifyTaxBasis, Action<string> otherwise)
    {
        if (this == ModifyTaxBasis) onModifyTaxBasis();
        else if (this == DoNotModifyTaxBasis) onDoNotModifyTaxBasis();
        else otherwise(Value);
    }
}

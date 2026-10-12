using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Determines the type of a specific Quick Amount.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogQuickAmountType>))]
public sealed record CatalogQuickAmountType : OpenStringEnum<CatalogQuickAmountType>
{
    private CatalogQuickAmountType(string value) : base(value)
    {
    }

    /// <summary>
    /// Quick Amount is created manually by the seller.
    /// </summary>
    public static readonly CatalogQuickAmountType QuickAmountTypeManual = new("QUICK_AMOUNT_TYPE_MANUAL");

    /// <summary>
    /// Quick Amount is generated automatically by machine learning algorithms.
    /// </summary>
    public static readonly CatalogQuickAmountType QuickAmountTypeAuto = new("QUICK_AMOUNT_TYPE_AUTO");

    public TResult Match<TResult>(Func<TResult> onQuickAmountTypeManual,
        Func<TResult> onQuickAmountTypeAuto,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == QuickAmountTypeManual => onQuickAmountTypeManual(),
            _ when this == QuickAmountTypeAuto => onQuickAmountTypeAuto(),
            _ => otherwise(Value)
        };

    public void Match(Action onQuickAmountTypeManual, Action onQuickAmountTypeAuto, Action<string> otherwise)
    {
        if (this == QuickAmountTypeManual) onQuickAmountTypeManual();
        else if (this == QuickAmountTypeAuto) onQuickAmountTypeAuto();
        else otherwise(Value);
    }
}

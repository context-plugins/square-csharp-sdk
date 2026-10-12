using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// When to calculate the taxes due on a cart.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TaxCalculationPhase>))]
public sealed record TaxCalculationPhase : OpenStringEnum<TaxCalculationPhase>
{
    private TaxCalculationPhase(string value) : base(value)
    {
    }

    /// <summary>
    /// The fee is calculated based on the payment's subtotal.
    /// </summary>
    public static readonly TaxCalculationPhase TaxSubtotalPhase = new("TAX_SUBTOTAL_PHASE");

    /// <summary>
    /// The fee is calculated based on the payment's total.
    /// </summary>
    public static readonly TaxCalculationPhase TaxTotalPhase = new("TAX_TOTAL_PHASE");

    public TResult Match<TResult>(Func<TResult> onTaxSubtotalPhase,
        Func<TResult> onTaxTotalPhase,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == TaxSubtotalPhase => onTaxSubtotalPhase(),
            _ when this == TaxTotalPhase => onTaxTotalPhase(),
            _ => otherwise(Value)
        };

    public void Match(Action onTaxSubtotalPhase, Action onTaxTotalPhase, Action<string> otherwise)
    {
        if (this == TaxSubtotalPhase) onTaxSubtotalPhase();
        else if (this == TaxTotalPhase) onTaxTotalPhase();
        else otherwise(Value);
    }
}

using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Represents a phase in the process of calculating order totals.
/// Service charges are applied after the indicated phase.
/// <para>
/// <see href="https://developer.squareup.com/docs/orders-api/how-it-works#how-totals-are-calculated">Read more about how order totals are calculated.</see>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderServiceChargeCalculationPhase>))]
public sealed record OrderServiceChargeCalculationPhase : OpenStringEnum<OrderServiceChargeCalculationPhase>
{
    private OrderServiceChargeCalculationPhase(string value) : base(value)
    {
    }

    /// <summary>
    /// The service charge is applied after discounts, but before
    /// taxes.
    /// </summary>
    public static readonly OrderServiceChargeCalculationPhase SubtotalPhase = new("SUBTOTAL_PHASE");

    /// <summary>
    /// The service charge is applied after all discounts and taxes
    /// are applied.
    /// </summary>
    public static readonly OrderServiceChargeCalculationPhase TotalPhase = new("TOTAL_PHASE");

    /// <summary>
    /// The service charge is calculated as a compounding adjustment
    /// after any discounts, but before amount based apportioned service charges
    /// and any tax considerations.
    /// </summary>
    public static readonly OrderServiceChargeCalculationPhase ApportionedPercentagePhase = new(
        "APPORTIONED_PERCENTAGE_PHASE");

    /// <summary>
    /// The service charge is calculated as a compounding adjustment
    /// after any discounts and percentage based apportioned service charges,
    /// but before any tax considerations.
    /// </summary>
    public static readonly OrderServiceChargeCalculationPhase ApportionedAmountPhase = new("APPORTIONED_AMOUNT_PHASE");

    public TResult Match<TResult>(Func<TResult> onSubtotalPhase,
        Func<TResult> onTotalPhase,
        Func<TResult> onApportionedPercentagePhase,
        Func<TResult> onApportionedAmountPhase,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SubtotalPhase => onSubtotalPhase(),
            _ when this == TotalPhase => onTotalPhase(),
            _ when this == ApportionedPercentagePhase => onApportionedPercentagePhase(),
            _ when this == ApportionedAmountPhase => onApportionedAmountPhase(),
            _ => otherwise(Value)
        };

    public void Match(Action onSubtotalPhase,
        Action onTotalPhase,
        Action onApportionedPercentagePhase,
        Action onApportionedAmountPhase,
        Action<string> otherwise)
    {
        if (this == SubtotalPhase) onSubtotalPhase();
        else if (this == TotalPhase) onTotalPhase();
        else if (this == ApportionedPercentagePhase) onApportionedPercentagePhase();
        else if (this == ApportionedAmountPhase) onApportionedAmountPhase();
        else otherwise(Value);
    }
}

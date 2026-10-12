using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates how taxes should be treated when calculating the purchase amount used for loyalty points accrual.
/// This setting applies only to <c>SPEND</c> accrual rules or <c>VISIT</c> accrual rules that have a minimum spend requirement.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyProgramAccrualRuleTaxMode>))]
public sealed record LoyaltyProgramAccrualRuleTaxMode : OpenStringEnum<LoyaltyProgramAccrualRuleTaxMode>
{
    private LoyaltyProgramAccrualRuleTaxMode(string value) : base(value)
    {
    }

    /// <summary>
    /// Exclude taxes from the purchase amount used for loyalty points accrual.
    /// </summary>
    public static readonly LoyaltyProgramAccrualRuleTaxMode BeforeTax = new("BEFORE_TAX");

    /// <summary>
    /// Include taxes in the purchase amount used for loyalty points accrual.
    /// </summary>
    public static readonly LoyaltyProgramAccrualRuleTaxMode AfterTax = new("AFTER_TAX");

    public TResult Match<TResult>(Func<TResult> onBeforeTax,
        Func<TResult> onAfterTax,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BeforeTax => onBeforeTax(),
            _ when this == AfterTax => onAfterTax(),
            _ => otherwise(Value)
        };

    public void Match(Action onBeforeTax, Action onAfterTax, Action<string> otherwise)
    {
        if (this == BeforeTax) onBeforeTax();
        else if (this == AfterTax) onAfterTax();
        else otherwise(Value);
    }
}

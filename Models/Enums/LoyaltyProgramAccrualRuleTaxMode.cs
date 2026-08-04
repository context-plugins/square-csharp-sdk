using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates how taxes should be treated when calculating the purchase amount used for loyalty points accrual.
/// This setting applies only to <c>SPEND</c> accrual rules or <c>VISIT</c> accrual rules that have a minimum spend requirement.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyProgramAccrualRuleTaxMode>))]
public sealed record LoyaltyProgramAccrualRuleTaxMode : StringEnum<LoyaltyProgramAccrualRuleTaxMode>
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

    public static LoyaltyProgramAccrualRuleTaxMode FromValue(string value) => FromValueCore(value);
}

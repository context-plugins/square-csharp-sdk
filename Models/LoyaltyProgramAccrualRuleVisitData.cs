using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents additional data for rules with the <c>VISIT</c> accrual type.
/// </summary>
public record LoyaltyProgramAccrualRuleVisitData
{
    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minimum_amount_money")]
    public Money? MinimumAmountMoney { get; init; }

    /// <summary>
    /// Indicates how taxes should be treated when calculating the purchase amount used for loyalty points accrual.
    /// This setting applies only to <c>SPEND</c> accrual rules or <c>VISIT</c> accrual rules that have a minimum spend requirement.
    /// </summary>
    [JsonPropertyName("tax_mode")]
    public required LoyaltyProgramAccrualRuleTaxMode TaxMode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The type of the accrual rule that defines how buyers can earn points.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyProgramAccrualRuleType>))]
public sealed record LoyaltyProgramAccrualRuleType : OpenStringEnum<LoyaltyProgramAccrualRuleType>
{
    private LoyaltyProgramAccrualRuleType(string value) : base(value)
    {
    }

    /// <summary>
    /// A visit-based accrual rule. A buyer earns points for each visit.
    /// You can specify the minimum purchase required.
    /// </summary>
    public static readonly LoyaltyProgramAccrualRuleType Visit = new("VISIT");

    /// <summary>
    /// A spend-based accrual rule. A buyer earns points based on the amount
    /// spent.
    /// </summary>
    public static readonly LoyaltyProgramAccrualRuleType Spend = new("SPEND");

    /// <summary>
    /// An accrual rule based on an item variation. For example, accrue
    /// points for purchasing a coffee.
    /// </summary>
    public static readonly LoyaltyProgramAccrualRuleType ItemVariation = new("ITEM_VARIATION");

    /// <summary>
    /// An accrual rule based on an item category. For example, accrue points
    /// for purchasing any item in the "hot drink" category: coffee, tea, or hot cocoa.
    /// </summary>
    public static readonly LoyaltyProgramAccrualRuleType Category = new("CATEGORY");

    public TResult Match<TResult>(Func<TResult> onVisit,
        Func<TResult> onSpend,
        Func<TResult> onItemVariation,
        Func<TResult> onCategory,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Visit => onVisit(),
            _ when this == Spend => onSpend(),
            _ when this == ItemVariation => onItemVariation(),
            _ when this == Category => onCategory(),
            _ => otherwise(Value)
        };

    public void Match(Action onVisit,
        Action onSpend,
        Action onItemVariation,
        Action onCategory,
        Action<string> otherwise)
    {
        if (this == Visit) onVisit();
        else if (this == Spend) onSpend();
        else if (this == ItemVariation) onItemVariation();
        else if (this == Category) onCategory();
        else otherwise(Value);
    }
}

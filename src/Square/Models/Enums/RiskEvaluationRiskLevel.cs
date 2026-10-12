using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<RiskEvaluationRiskLevel>))]
public sealed record RiskEvaluationRiskLevel : OpenStringEnum<RiskEvaluationRiskLevel>
{
    private RiskEvaluationRiskLevel(string value) : base(value)
    {
    }

    /// <summary>
    /// Indicates Square is still evaluating the payment.
    /// </summary>
    public static readonly RiskEvaluationRiskLevel Pending = new("PENDING");

    /// <summary>
    /// Indicates payment risk is within the normal range.
    /// </summary>
    public static readonly RiskEvaluationRiskLevel Normal = new("NORMAL");

    /// <summary>
    /// Indicates elevated risk level associated with the payment.
    /// </summary>
    public static readonly RiskEvaluationRiskLevel Moderate = new("MODERATE");

    /// <summary>
    /// Indicates significantly elevated risk level with the payment.
    /// </summary>
    public static readonly RiskEvaluationRiskLevel High = new("HIGH");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onNormal,
        Func<TResult> onModerate,
        Func<TResult> onHigh,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Normal => onNormal(),
            _ when this == Moderate => onModerate(),
            _ when this == High => onHigh(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending, Action onNormal, Action onModerate, Action onHigh, Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Normal) onNormal();
        else if (this == Moderate) onModerate();
        else if (this == High) onHigh();
        else otherwise(Value);
    }
}

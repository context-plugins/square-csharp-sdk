using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates whether the card surcharge will be treated as a value-holding line item or
/// apportioned across all line items.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderCardSurchargeTreatmentType>))]
public sealed record OrderCardSurchargeTreatmentType : OpenStringEnum<OrderCardSurchargeTreatmentType>
{
    private OrderCardSurchargeTreatmentType(string value) : base(value)
    {
    }

    public static readonly OrderCardSurchargeTreatmentType LineItemTreatment = new("LINE_ITEM_TREATMENT");

    public static readonly OrderCardSurchargeTreatmentType ApportionedTreatment = new("APPORTIONED_TREATMENT");

    public TResult Match<TResult>(Func<TResult> onLineItemTreatment,
        Func<TResult> onApportionedTreatment,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == LineItemTreatment => onLineItemTreatment(),
            _ when this == ApportionedTreatment => onApportionedTreatment(),
            _ => otherwise(Value)
        };

    public void Match(Action onLineItemTreatment, Action onApportionedTreatment, Action<string> otherwise)
    {
        if (this == LineItemTreatment) onLineItemTreatment();
        else if (this == ApportionedTreatment) onApportionedTreatment();
        else otherwise(Value);
    }
}

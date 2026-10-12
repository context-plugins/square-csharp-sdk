using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates whether the service charge will be treated as a value-holding line item or
/// apportioned toward a line item.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderServiceChargeTreatmentType>))]
public sealed record OrderServiceChargeTreatmentType : OpenStringEnum<OrderServiceChargeTreatmentType>
{
    private OrderServiceChargeTreatmentType(string value) : base(value)
    {
    }

    public static readonly OrderServiceChargeTreatmentType LineItemTreatment = new("LINE_ITEM_TREATMENT");

    public static readonly OrderServiceChargeTreatmentType ApportionedTreatment = new("APPORTIONED_TREATMENT");

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

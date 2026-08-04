using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates whether the card surcharge will be treated as a value-holding line item or
/// apportioned across all line items.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderCardSurchargeTreatmentType>))]
public sealed record OrderCardSurchargeTreatmentType : StringEnum<OrderCardSurchargeTreatmentType>
{
    private OrderCardSurchargeTreatmentType(string value) : base(value)
    {
    }

    public static readonly OrderCardSurchargeTreatmentType LineItemTreatment = new("LINE_ITEM_TREATMENT");

    public static readonly OrderCardSurchargeTreatmentType ApportionedTreatment = new("APPORTIONED_TREATMENT");

    public static OrderCardSurchargeTreatmentType FromValue(string value) => FromValueCore(value);
}

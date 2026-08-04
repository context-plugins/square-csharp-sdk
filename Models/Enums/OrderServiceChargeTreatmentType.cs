using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates whether the service charge will be treated as a value-holding line item or
/// apportioned toward a line item.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderServiceChargeTreatmentType>))]
public sealed record OrderServiceChargeTreatmentType : StringEnum<OrderServiceChargeTreatmentType>
{
    private OrderServiceChargeTreatmentType(string value) : base(value)
    {
    }

    public static readonly OrderServiceChargeTreatmentType LineItemTreatment = new("LINE_ITEM_TREATMENT");

    public static readonly OrderServiceChargeTreatmentType ApportionedTreatment = new("APPORTIONED_TREATMENT");

    public static OrderServiceChargeTreatmentType FromValue(string value) => FromValueCore(value);
}

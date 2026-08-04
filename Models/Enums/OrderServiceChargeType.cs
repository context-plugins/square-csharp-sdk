using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<OrderServiceChargeType>))]
public sealed record OrderServiceChargeType : StringEnum<OrderServiceChargeType>
{
    private OrderServiceChargeType(string value) : base(value)
    {
    }

    public static readonly OrderServiceChargeType AutoGratuity = new("AUTO_GRATUITY");

    public static readonly OrderServiceChargeType Custom = new("CUSTOM");

    public static OrderServiceChargeType FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The type of fulfillment.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderFulfillmentType>))]
public sealed record OrderFulfillmentType : StringEnum<OrderFulfillmentType>
{
    private OrderFulfillmentType(string value) : base(value)
    {
    }

    /// <summary>
    /// A recipient to pick up the fulfillment from a physical <see href="entity:Location">location</see>.
    /// </summary>
    public static readonly OrderFulfillmentType Pickup = new("PICKUP");

    /// <summary>
    /// A shipping carrier to ship the fulfillment.
    /// </summary>
    public static readonly OrderFulfillmentType Shipment = new("SHIPMENT");

    /// <summary>
    /// A courier to deliver the fulfillment.
    /// </summary>
    public static readonly OrderFulfillmentType Delivery = new("DELIVERY");

    public static OrderFulfillmentType FromValue(string value) => FromValueCore(value);
}

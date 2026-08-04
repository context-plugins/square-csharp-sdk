using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The type of fulfillment.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FulfillmentType>))]
public sealed record FulfillmentType : StringEnum<FulfillmentType>
{
    private FulfillmentType(string value) : base(value)
    {
    }

    /// <summary>
    /// A recipient to pick up the fulfillment from a physical <see href="entity:Location">location</see>.
    /// </summary>
    public static readonly FulfillmentType Pickup = new("PICKUP");

    /// <summary>
    /// A shipping carrier to ship the fulfillment.
    /// </summary>
    public static readonly FulfillmentType Shipment = new("SHIPMENT");

    /// <summary>
    /// A courier to deliver the fulfillment.
    /// </summary>
    public static readonly FulfillmentType Delivery = new("DELIVERY");

    /// <summary>
    /// A customer to receive the fulfillment within the seller's physical <see href="entity:Location">location</see>.
    /// </summary>
    public static readonly FulfillmentType InStore = new("IN_STORE");

    public static FulfillmentType FromValue(string value) => FromValueCore(value);
}

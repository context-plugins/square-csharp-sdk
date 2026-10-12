using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The type of fulfillment.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderFulfillmentType>))]
public sealed record OrderFulfillmentType : OpenStringEnum<OrderFulfillmentType>
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

    public TResult Match<TResult>(Func<TResult> onPickup,
        Func<TResult> onShipment,
        Func<TResult> onDelivery,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pickup => onPickup(),
            _ when this == Shipment => onShipment(),
            _ when this == Delivery => onDelivery(),
            _ => otherwise(Value)
        };

    public void Match(Action onPickup, Action onShipment, Action onDelivery, Action<string> otherwise)
    {
        if (this == Pickup) onPickup();
        else if (this == Shipment) onShipment();
        else if (this == Delivery) onDelivery();
        else otherwise(Value);
    }
}

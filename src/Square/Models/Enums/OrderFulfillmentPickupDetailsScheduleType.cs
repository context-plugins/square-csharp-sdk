using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The schedule type of the pickup fulfillment.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderFulfillmentPickupDetailsScheduleType>))]
public sealed record OrderFulfillmentPickupDetailsScheduleType : OpenStringEnum<OrderFulfillmentPickupDetailsScheduleType>
{
    private OrderFulfillmentPickupDetailsScheduleType(string value) : base(value)
    {
    }

    /// <summary>
    /// Indicates that the fulfillment will be picked up at a scheduled pickup time.
    /// </summary>
    public static readonly OrderFulfillmentPickupDetailsScheduleType Scheduled = new("SCHEDULED");

    /// <summary>
    /// Indicates that the fulfillment will be picked up as soon as possible and
    /// should be prepared immediately.
    /// </summary>
    public static readonly OrderFulfillmentPickupDetailsScheduleType Asap = new("ASAP");

    public TResult Match<TResult>(Func<TResult> onScheduled, Func<TResult> onAsap, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Scheduled => onScheduled(),
            _ when this == Asap => onAsap(),
            _ => otherwise(Value)
        };

    public void Match(Action onScheduled, Action onAsap, Action<string> otherwise)
    {
        if (this == Scheduled) onScheduled();
        else if (this == Asap) onAsap();
        else otherwise(Value);
    }
}

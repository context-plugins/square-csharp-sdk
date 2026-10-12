using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The schedule type of the delivery fulfillment.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderFulfillmentDeliveryDetailsScheduleType>))]
public sealed record OrderFulfillmentDeliveryDetailsScheduleType : OpenStringEnum<OrderFulfillmentDeliveryDetailsScheduleType>
{
    private OrderFulfillmentDeliveryDetailsScheduleType(string value) : base(value)
    {
    }

    /// <summary>
    /// Indicates the fulfillment to deliver at a scheduled deliver time.
    /// </summary>
    public static readonly OrderFulfillmentDeliveryDetailsScheduleType Scheduled = new("SCHEDULED");

    /// <summary>
    /// Indicates that the fulfillment to deliver as soon as possible and should be prepared
    /// immediately.
    /// </summary>
    public static readonly OrderFulfillmentDeliveryDetailsScheduleType Asap = new("ASAP");

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

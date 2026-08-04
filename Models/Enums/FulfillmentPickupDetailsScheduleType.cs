using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The schedule type of the pickup fulfillment.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FulfillmentPickupDetailsScheduleType>))]
public sealed record FulfillmentPickupDetailsScheduleType : StringEnum<FulfillmentPickupDetailsScheduleType>
{
    private FulfillmentPickupDetailsScheduleType(string value) : base(value)
    {
    }

    /// <summary>
    /// Indicates that the fulfillment will be picked up at a scheduled pickup time.
    /// </summary>
    public static readonly FulfillmentPickupDetailsScheduleType Scheduled = new("SCHEDULED");

    /// <summary>
    /// Indicates that the fulfillment will be picked up as soon as possible and
    /// should be prepared immediately.
    /// </summary>
    public static readonly FulfillmentPickupDetailsScheduleType Asap = new("ASAP");

    public static FulfillmentPickupDetailsScheduleType FromValue(string value) => FromValueCore(value);
}

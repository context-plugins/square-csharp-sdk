using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The current state of this fulfillment.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FulfillmentState>))]
public sealed record FulfillmentState : StringEnum<FulfillmentState>
{
    private FulfillmentState(string value) : base(value)
    {
    }

    /// <summary>
    /// Indicates that the fulfillment has been proposed.
    /// </summary>
    public static readonly FulfillmentState Proposed = new("PROPOSED");

    /// <summary>
    /// Indicates that the fulfillment has been reserved.
    /// </summary>
    public static readonly FulfillmentState Reserved = new("RESERVED");

    /// <summary>
    /// Indicates that the fulfillment has been prepared.
    /// </summary>
    public static readonly FulfillmentState Prepared = new("PREPARED");

    /// <summary>
    /// Indicates that the fulfillment was successfully completed.
    /// </summary>
    public static readonly FulfillmentState Completed = new("COMPLETED");

    /// <summary>
    /// Indicates that the fulfillment was canceled.
    /// </summary>
    public static readonly FulfillmentState Canceled = new("CANCELED");

    /// <summary>
    /// Indicates that the fulfillment failed to be completed, but was not explicitly
    /// canceled.
    /// </summary>
    public static readonly FulfillmentState Failed = new("FAILED");

    public static FulfillmentState FromValue(string value) => FromValueCore(value);
}

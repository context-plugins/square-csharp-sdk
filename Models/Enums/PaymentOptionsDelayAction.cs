using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Describes the action to be applied to a delayed capture payment when the delay_duration
/// has elapsed.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentOptionsDelayAction>))]
public sealed record PaymentOptionsDelayAction : StringEnum<PaymentOptionsDelayAction>
{
    private PaymentOptionsDelayAction(string value) : base(value)
    {
    }

    /// <summary>
    /// Indicates that the payment should be automatically canceled when the delay duration
    /// elapses.
    /// </summary>
    public static readonly PaymentOptionsDelayAction Cancel = new("CANCEL");

    /// <summary>
    /// Indicates that the payment should be automatically completed when the delay duration
    /// elapses.
    /// </summary>
    public static readonly PaymentOptionsDelayAction Complete = new("COMPLETE");

    public static PaymentOptionsDelayAction FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Payout status types
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PayoutStatus>))]
public sealed record PayoutStatus : StringEnum<PayoutStatus>
{
    private PayoutStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// Indicates that the payout was successfully sent to the banking destination.
    /// </summary>
    public static readonly PayoutStatus Sent = new("SENT");

    /// <summary>
    /// Indicates that the payout was rejected by the banking destination.
    /// </summary>
    public static readonly PayoutStatus Failed = new("FAILED");

    /// <summary>
    /// Indicates that the payout has successfully completed.
    /// </summary>
    public static readonly PayoutStatus Paid = new("PAID");

    public static PayoutStatus FromValue(string value) => FromValueCore(value);
}

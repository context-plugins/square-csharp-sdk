using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The type of payout: “BATCH” or “SIMPLE”.
/// BATCH payouts include a list of payout entries that can be considered settled.
/// SIMPLE payouts do not have any payout entries associated with them
/// and will show up as one of the payout entries in a future BATCH payout.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PayoutType>))]
public sealed record PayoutType : StringEnum<PayoutType>
{
    private PayoutType(string value) : base(value)
    {
    }

    /// <summary>
    /// Payouts that include a list of payout entries that can be considered settled.
    /// </summary>
    public static readonly PayoutType Batch = new("BATCH");

    /// <summary>
    /// Payouts that do not have any payout entries associated with them and will
    /// show up as one of the payout entries in a future BATCH payout.
    /// </summary>
    public static readonly PayoutType Simple = new("SIMPLE");

    public static PayoutType FromValue(string value) => FromValueCore(value);
}

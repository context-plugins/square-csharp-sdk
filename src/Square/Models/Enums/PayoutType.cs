using System;
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
public sealed record PayoutType : OpenStringEnum<PayoutType>
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

    public TResult Match<TResult>(Func<TResult> onBatch, Func<TResult> onSimple, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Batch => onBatch(),
            _ when this == Simple => onSimple(),
            _ => otherwise(Value)
        };

    public void Match(Action onBatch, Action onSimple, Action<string> otherwise)
    {
        if (this == Batch) onBatch();
        else if (this == Simple) onSimple();
        else otherwise(Value);
    }
}

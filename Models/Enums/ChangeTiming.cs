using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Supported timings when a pending change, as an action, takes place to a subscription.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ChangeTiming>))]
public sealed record ChangeTiming : StringEnum<ChangeTiming>
{
    private ChangeTiming(string value) : base(value)
    {
    }

    /// <summary>
    /// The action occurs immediately.
    /// </summary>
    public static readonly ChangeTiming Immediate = new("IMMEDIATE");

    /// <summary>
    /// The action occurs at the end of the billing cycle.
    /// </summary>
    public static readonly ChangeTiming EndOfBillingCycle = new("END_OF_BILLING_CYCLE");

    public static ChangeTiming FromValue(string value) => FromValueCore(value);
}

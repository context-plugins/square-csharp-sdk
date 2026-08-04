using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Describes a phase in a subscription plan variation. For more information, see <see href="https://developer.squareup.com/docs/subscriptions-api/plans-and-variations">Subscription Plans and Variations</see>.
/// </summary>
public record SubscriptionPhase
{
    /// <summary>
    /// The Square-assigned ID of the subscription phase. This field cannot be changed after a <c>SubscriptionPhase</c> is created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    public string? Uid { get; init; }

    /// <summary>
    /// Determines the billing cadence of a <see href="entity:Subscription">Subscription</see>
    /// </summary>
    [JsonPropertyName("cadence")]
    public required SubscriptionCadence Cadence { get; init; }

    /// <summary>
    /// The number of <c>cadence</c>s the phase lasts. If not set, the phase never ends. Only the last phase can be indefinite. This field cannot be changed after a <c>SubscriptionPhase</c> is created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("periods")]
    public int? Periods { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurring_price_money")]
    public Money? RecurringPriceMoney { get; init; }

    /// <summary>
    /// The position this phase appears in the sequence of phases defined for the plan, indexed from 0. This field cannot be changed after a <c>SubscriptionPhase</c> is created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ordinal")]
    public long? Ordinal { get; init; }

    /// <summary>
    /// Describes the pricing for the subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pricing")]
    public SubscriptionPricing? Pricing { get; init; }
}

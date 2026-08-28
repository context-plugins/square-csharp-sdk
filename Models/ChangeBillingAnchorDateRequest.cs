using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// Defines input parameters in a request to the
/// <see href="api-endpoint:Subscriptions-ChangeBillingAnchorDate">ChangeBillingAnchorDate</see> endpoint.
/// </summary>
public record ChangeBillingAnchorDateRequest
{
    /// <summary>
    /// The anchor day for the billing cycle.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("monthly_billing_anchor_date")]
    [Minimum(1)]
    [Maximum(31)]
    public int? MonthlyBillingAnchorDate { get; init; }

    /// <summary>
    /// The <c>YYYY-MM-DD</c>-formatted date when the scheduled <c>BILLING_ANCHOR_CHANGE</c> action takes
    /// place on the subscription.
    /// <para>
    /// When this date is unspecified or falls within the current billing cycle, the billing anchor date
    /// is changed immediately.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("effective_date")]
    public string? EffectiveDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

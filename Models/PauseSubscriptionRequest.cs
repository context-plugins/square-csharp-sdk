using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Defines input parameters in a request to the
/// <see href="api-endpoint:Subscriptions-PauseSubscription">PauseSubscription</see> endpoint.
/// </summary>
public record PauseSubscriptionRequest
{
    /// <summary>
    /// The <c>YYYY-MM-DD</c>-formatted date when the scheduled <c>PAUSE</c> action takes place on the subscription.
    /// <para>
    /// When this date is unspecified or falls within the current billing cycle, the subscription is paused
    /// on the starting date of the next billing cycle.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pause_effective_date")]
    public string? PauseEffectiveDate { get; init; }

    /// <summary>
    /// The number of billing cycles the subscription will be paused before it is reactivated.
    /// <para>
    /// When this is set, a <c>RESUME</c> action is also scheduled to take place on the subscription at
    /// the end of the specified pause cycle duration. In this case, neither <c>resume_effective_date</c>
    /// nor <c>resume_change_timing</c> may be specified.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pause_cycle_duration")]
    public long? PauseCycleDuration { get; init; }

    /// <summary>
    /// The date when the subscription is reactivated by a scheduled <c>RESUME</c> action.
    /// This date must be at least one billing cycle ahead of <c>pause_effective_date</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resume_effective_date")]
    public string? ResumeEffectiveDate { get; init; }

    /// <summary>
    /// Supported timings when a pending change, as an action, takes place to a subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resume_change_timing")]
    public ChangeTiming? ResumeChangeTiming { get; init; }

    /// <summary>
    /// The user-provided reason to pause the subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pause_reason")]
    [MaxLength(255)]
    public string? PauseReason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

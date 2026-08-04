using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Defines input parameters in a request to the
/// <see href="api-endpoint:Subscriptions-ResumeSubscription">ResumeSubscription</see> endpoint.
/// </summary>
public record ResumeSubscriptionRequest
{
    /// <summary>
    /// The <c>YYYY-MM-DD</c>-formatted date when the subscription reactivated.
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
}

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Defines input parameters in a call to the
/// <see href="api-endpoint:Subscriptions-SwapPlan">SwapPlan</see> endpoint.
/// </summary>
public record SwapPlanRequest
{
    /// <summary>
    /// The ID of the new subscription plan variation.
    /// <para>
    /// This field is required.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("new_plan_variation_id")]
    public string? NewPlanVariationId { get; init; }

    /// <summary>
    /// A list of PhaseInputs, to pass phase-specific information used in the swap.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phases")]
    public IReadOnlyList<PhaseInput?>? Phases { get; init; }
}

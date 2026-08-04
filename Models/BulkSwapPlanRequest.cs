using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Defines input parameters in a call to the
/// <see href="api-endpoint:Subscriptions-BulkSwapPlan">BulkSwapPlan</see> endpoint.
/// </summary>
public record BulkSwapPlanRequest
{
    /// <summary>
    /// The ID of the new subscription plan variation.
    /// <para>
    /// This field is required.
    /// </para>
    /// </summary>
    [JsonPropertyName("new_plan_variation_id")]
    [MinLength(1)]
    public required string NewPlanVariationId { get; init; }

    /// <summary>
    /// The ID of the plan variation whose subscriptions should be swapped. Active subscriptions
    /// using this plan variation will be subscribed to the new plan variation on their next billing
    /// day.
    /// </summary>
    [JsonPropertyName("old_plan_variation_id")]
    [MinLength(1)]
    public required string OldPlanVariationId { get; init; }

    /// <summary>
    /// The ID of the location to associate with the swapped subscriptions.
    /// </summary>
    [JsonPropertyName("location_id")]
    [MinLength(1)]
    public required string LocationId { get; init; }
}

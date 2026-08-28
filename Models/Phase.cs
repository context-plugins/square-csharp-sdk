using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a phase, which can override subscription phases as defined by plan_id
/// </summary>
public record Phase
{
    /// <summary>
    /// id of subscription phase
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    public string? Uid { get; init; }

    /// <summary>
    /// index of phase in total subscription plan
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ordinal")]
    public long? Ordinal { get; init; }

    /// <summary>
    /// id of order to be used in billing
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_template_id")]
    public string? OrderTemplateId { get; init; }

    /// <summary>
    /// the uid from the plan's phase in catalog
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plan_phase_uid")]
    public string? PlanPhaseUid { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

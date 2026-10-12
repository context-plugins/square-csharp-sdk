using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents the arguments used to construct a new phase.
/// </summary>
public record PhaseInput
{
    /// <summary>
    /// index of phase in total subscription plan
    /// </summary>
    [JsonPropertyName("ordinal")]
    public required long Ordinal { get; init; }

    /// <summary>
    /// id of order to be used in billing
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_template_id")]
    public string? OrderTemplateId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

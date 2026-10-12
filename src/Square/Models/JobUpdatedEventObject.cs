using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record JobUpdatedEventObject
{
    /// <summary>
    /// Represents a job that can be assigned to <see href="entity:TeamMember">team members</see>. This object defines the
    /// job's title and tip eligibility. Compensation is defined in a <see href="entity:JobAssignment">job assignment</see>
    /// in a team member's wage setting.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("job")]
    public Job? Job { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

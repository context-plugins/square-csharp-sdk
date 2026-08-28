using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an <see href="api-endpoint:Team-UpdateJob">UpdateJob</see> request.
/// </summary>
public record UpdateJobRequest
{
    /// <summary>
    /// Represents a job that can be assigned to <see href="entity:TeamMember">team members</see>. This object defines the
    /// job's title and tip eligibility. Compensation is defined in a <see href="entity:JobAssignment">job assignment</see>
    /// in a team member's wage setting.
    /// </summary>
    [JsonPropertyName("job")]
    public required Job Job { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

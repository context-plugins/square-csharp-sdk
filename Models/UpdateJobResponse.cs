using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an <see href="api-endpoint:Team-UpdateJob">UpdateJob</see> response. Either <c>job</c> or <c>errors</c>
/// is present in the response.
/// </summary>
public record UpdateJobResponse
{
    /// <summary>
    /// Represents a job that can be assigned to <see href="entity:TeamMember">team members</see>. This object defines the
    /// job's title and tip eligibility. Compensation is defined in a <see href="entity:JobAssignment">job assignment</see>
    /// in a team member's wage setting.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("job")]
    public Job? Job { get; init; }

    /// <summary>
    /// The errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

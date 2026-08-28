using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:Team-CreateJob">CreateJob</see> request.
/// </summary>
public record CreateJobRequest
{
    /// <summary>
    /// Represents a job that can be assigned to <see href="entity:TeamMember">team members</see>. This object defines the
    /// job's title and tip eligibility. Compensation is defined in a <see href="entity:JobAssignment">job assignment</see>
    /// in a team member's wage setting.
    /// </summary>
    [JsonPropertyName("job")]
    public required Job Job { get; init; }

    /// <summary>
    /// A unique identifier for the <c>CreateJob</c> request. Keys can be any valid string,
    /// but must be unique for each request. For more information, see
    /// <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">Idempotency</see>.
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(45, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a job that can be assigned to <see href="entity:TeamMember">team members</see>. This object defines the
/// job's title and tip eligibility. Compensation is defined in a <see href="entity:JobAssignment">job assignment</see>
/// in a team member's wage setting.
/// </summary>
public record Job
{
    /// <summary>
    /// <b>Read only</b> The unique Square-assigned ID of the job. If you need a job ID for an API request,
    /// call <see href="api-endpoint:Team-ListJobs">ListJobs</see> or use the ID returned when you created the job.
    /// You can also get job IDs from a team member's wage setting.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The title of the job.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    [MaxLength(150)]
    public string? Title { get; init; }

    /// <summary>
    /// Indicates whether team members can earn tips for the job.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_tip_eligible")]
    public bool? IsTipEligible { get; init; }

    /// <summary>
    /// The timestamp when the job was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The timestamp when the job was last updated, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// <b>Read only</b> The current version of the job. Include this field in <c>UpdateJob</c> requests to enable
    /// <see href="https://developer.squareup.com/docs/working-with-apis/optimistic-concurrency">optimistic concurrency</see>
    /// control and avoid overwrites from concurrent requests. Requests fail if the provided version doesn't
    /// match the server version at the time of the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }
}

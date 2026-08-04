using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a specific time slot in a work schedule. This object is used to manage the
/// lifecycle of a scheduled shift from the draft to published state. A scheduled shift contains
/// the latest draft shift details and current published shift details.
/// </summary>
public record ScheduledShift
{
    /// <summary>
    /// <b>Read only</b> The Square-issued ID of the scheduled shift.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(255)]
    public string? Id { get; init; }

    /// <summary>
    /// Represents shift details for draft and published versions of a <see href="entity:ScheduledShift">scheduled shift</see>,
    /// such as job ID, team member assignment, and start and end times.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("draft_shift_details")]
    public ScheduledShiftDetails? DraftShiftDetails { get; init; }

    /// <summary>
    /// Represents shift details for draft and published versions of a <see href="entity:ScheduledShift">scheduled shift</see>,
    /// such as job ID, team member assignment, and start and end times.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("published_shift_details")]
    public ScheduledShiftDetails? PublishedShiftDetails { get; init; }

    /// <summary>
    /// <b>Read only</b> The current version of the scheduled shift, which is incremented with each update.
    /// This field is used for <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/optimistic-concurrency">optimistic concurrency</see>
    /// control to ensure that requests don't overwrite data from another request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    /// <summary>
    /// The timestamp of when the scheduled shift was created, in RFC 3339 format presented as UTC.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The timestamp of when the scheduled shift was last updated, in RFC 3339 format presented as UTC.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }
}

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// A record of a team member's break on a <see href="entity:Timecard">timecard</see>.
/// </summary>
public record Break
{
    /// <summary>
    /// The UUID for this object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// RFC 3339; follows the same timezone information as the <see href="entity:Timecard">timecard</see>. Precision up to
    /// the minute is respected; seconds are truncated.
    /// </summary>
    [JsonPropertyName("start_at")]
    [MinLength(1)]
    public required string StartAt { get; init; }

    /// <summary>
    /// RFC 3339; follows the same timezone information as the <see href="entity:Timecard">timecard</see>. Precision up to
    /// the minute is respected; seconds are truncated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_at")]
    public string? EndAt { get; init; }

    /// <summary>
    /// The <see href="entity:BreakType">BreakType</see> that this break was templated on.
    /// </summary>
    [JsonPropertyName("break_type_id")]
    [MinLength(1)]
    public required string BreakTypeId { get; init; }

    /// <summary>
    /// A human-readable name.
    /// </summary>
    [JsonPropertyName("name")]
    [MinLength(1)]
    public required string Name { get; init; }

    /// <summary>
    /// Format: RFC-3339 P[n]Y[n]M[n]DT[n]H[n]M[n]S. The expected length of
    /// the break.
    /// <para>
    /// Example for break expected duration of 15 minutes: PT15M
    /// </para>
    /// </summary>
    [JsonPropertyName("expected_duration")]
    [MinLength(1)]
    public required string ExpectedDuration { get; init; }

    /// <summary>
    /// Whether this break counts towards time worked for compensation
    /// purposes.
    /// </summary>
    [JsonPropertyName("is_paid")]
    public required bool IsPaid { get; init; }
}

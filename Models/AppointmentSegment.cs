using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// Defines an appointment segment of a booking.
/// </summary>
public record AppointmentSegment
{
    /// <summary>
    /// The time span in minutes of an appointment segment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("duration_minutes")]
    [Maximum(1500)]
    public int? DurationMinutes { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:CatalogItemVariation">CatalogItemVariation</see> object representing the service booked in this segment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("service_variation_id")]
    [MaxLength(36)]
    public string? ServiceVariationId { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:TeamMember">TeamMember</see> object representing the team member booked in this segment.
    /// </summary>
    [JsonPropertyName("team_member_id")]
    [StringLength(32, MinimumLength = 1)]
    public required string TeamMemberId { get; init; }

    /// <summary>
    /// The current version of the item variation representing the service booked in this segment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("service_variation_version")]
    public long? ServiceVariationVersion { get; init; }

    /// <summary>
    /// Time between the end of this segment and the beginning of the subsequent segment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("intermission_minutes")]
    public int? IntermissionMinutes { get; init; }

    /// <summary>
    /// Whether the customer accepts any team member, instead of a specific one, to serve this segment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("any_team_member")]
    public bool? AnyTeamMember { get; init; }

    /// <summary>
    /// The IDs of the seller-accessible resources used for this appointment segment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resource_ids")]
    public IReadOnlyList<string>? ResourceIds { get; init; }
}

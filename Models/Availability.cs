using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Defines an appointment slot that encapsulates the appointment segments, location and starting time available for booking.
/// </summary>
public record Availability
{
    /// <summary>
    /// The RFC 3339 timestamp specifying the beginning time of the slot available for booking.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_at")]
    public string? StartAt { get; init; }

    /// <summary>
    /// The ID of the location available for booking.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    [MaxLength(32)]
    public string? LocationId { get; init; }

    /// <summary>
    /// The list of appointment segments available for booking
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("appointment_segments")]
    public IReadOnlyList<AppointmentSegment?>? AppointmentSegments { get; init; }
}

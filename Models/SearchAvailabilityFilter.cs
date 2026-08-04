using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// A query filter to search for buyer-accessible availabilities by.
/// </summary>
public record SearchAvailabilityFilter
{
    /// <summary>
    /// Represents a generic time range. The start and end values are
    /// represented in RFC 3339 format. Time ranges are customized to be
    /// inclusive or exclusive based on the needs of a particular endpoint.
    /// Refer to the relevant endpoint-specific documentation to determine
    /// how time ranges are handled.
    /// </summary>
    [JsonPropertyName("start_at_range")]
    public required TimeRange StartAtRange { get; init; }

    /// <summary>
    /// The query expression to search for buyer-accessible availabilities with their location IDs matching the specified location ID.
    /// This query expression cannot be set if <c>booking_id</c> is set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    [MaxLength(32)]
    public string? LocationId { get; init; }

    /// <summary>
    /// The query expression to search for buyer-accessible availabilities matching the specified list of segment filters.
    /// If the size of the <c>segment_filters</c> list is <c>n</c>, the search returns availabilities with <c>n</c> segments per availability.
    /// <para>
    /// This query expression cannot be set if <c>booking_id</c> is set.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("segment_filters")]
    public IReadOnlyList<SegmentFilter?>? SegmentFilters { get; init; }

    /// <summary>
    /// The query expression to search for buyer-accessible availabilities for an existing booking by matching the specified <c>booking_id</c> value.
    /// This is commonly used to reschedule an appointment.
    /// If this expression is set, the <c>location_id</c> and <c>segment_filters</c> expressions cannot be set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("booking_id")]
    [MaxLength(36)]
    public string? BookingId { get; init; }
}

using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Request payload for bulk retrieval of bookings.
/// </summary>
public record BulkRetrieveBookingsRequest
{
    /// <summary>
    /// A non-empty list of <see href="entity:Booking">Booking</see> IDs specifying bookings to retrieve.
    /// </summary>
    [JsonPropertyName("booking_ids")]
    public required IReadOnlyList<string> BookingIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

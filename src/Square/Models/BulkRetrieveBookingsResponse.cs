using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Response payload for bulk retrieval of bookings.
/// </summary>
public record BulkRetrieveBookingsResponse
{
    /// <summary>
    /// Requested bookings returned as a map containing <c>booking_id</c> as the key and <c>RetrieveBookingResponse</c> as the value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bookings")]
    public IReadOnlyDictionary<string, RetrieveBookingResponse>? Bookings { get; init; }

    /// <summary>
    /// Errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

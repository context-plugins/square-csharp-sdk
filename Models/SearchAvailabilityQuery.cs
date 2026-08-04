using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// The query used to search for buyer-accessible availabilities of bookings.
/// </summary>
public record SearchAvailabilityQuery
{
    /// <summary>
    /// A query filter to search for buyer-accessible availabilities by.
    /// </summary>
    [JsonPropertyName("filter")]
    public required SearchAvailabilityFilter Filter { get; init; }
}

using System.Text.Json.Serialization;

namespace Square.Models;

public record SearchAvailabilityRequest
{
    /// <summary>
    /// The query used to search for buyer-accessible availabilities of bookings.
    /// </summary>
    [JsonPropertyName("query")]
    public required SearchAvailabilityQuery Query { get; init; }
}

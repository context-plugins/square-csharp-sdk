using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record SearchAvailabilityRequest
{
    /// <summary>
    /// The query used to search for buyer-accessible availabilities of bookings.
    /// </summary>
    [JsonPropertyName("query")]
    public required SearchAvailabilityQuery Query { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

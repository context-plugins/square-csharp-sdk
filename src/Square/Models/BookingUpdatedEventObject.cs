using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record BookingUpdatedEventObject
{
    /// <summary>
    /// Represents a booking as a time-bound service contract for a seller's staff member to provide a specified service
    /// at a given location to a requesting customer in one or more appointment segments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("booking")]
    public Booking? Booking { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

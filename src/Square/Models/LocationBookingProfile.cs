using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// The booking profile of a seller's location, including the location's ID and whether the location is enabled for online booking.
/// </summary>
public record LocationBookingProfile
{
    /// <summary>
    /// The ID of the <see href="entity:Location">location</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// Url for the online booking site for this location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("booking_site_url")]
    public string? BookingSiteUrl { get; init; }

    /// <summary>
    /// Indicates whether the location is enabled for online booking.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("online_booking_enabled")]
    public bool? OnlineBookingEnabled { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

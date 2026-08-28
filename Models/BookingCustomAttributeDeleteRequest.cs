using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an individual delete request in a <see href="api-endpoint:BookingCustomAttributes-BulkDeleteBookingCustomAttributes">BulkDeleteBookingCustomAttributes</see>
/// request. An individual request contains a booking ID, the custom attribute to delete, and an optional idempotency key.
/// </summary>
public record BookingCustomAttributeDeleteRequest
{
    /// <summary>
    /// The ID of the target <see href="entity:Booking">booking</see>.
    /// </summary>
    [JsonPropertyName("booking_id")]
    [StringLength(36, MinimumLength = 1)]
    public required string BookingId { get; init; }

    /// <summary>
    /// The key of the custom attribute to delete. This key must match the <c>key</c> of a
    /// custom attribute definition in the Square seller account. If the requesting application is not
    /// the definition owner, you must use the qualified key.
    /// </summary>
    [JsonPropertyName("key")]
    [MinLength(1)]
    public required string Key { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

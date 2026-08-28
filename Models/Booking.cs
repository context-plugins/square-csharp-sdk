using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a booking as a time-bound service contract for a seller's staff member to provide a specified service
/// at a given location to a requesting customer in one or more appointment segments.
/// </summary>
public record Booking
{
    /// <summary>
    /// A unique ID of this object representing a booking.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(36)]
    public string? Id { get; init; }

    /// <summary>
    /// The revision number for the booking used for optimistic concurrency.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    /// <summary>
    /// Supported booking statuses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public BookingStatus? Status { get; init; }

    /// <summary>
    /// The RFC 3339 timestamp specifying the creation time of this booking.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The RFC 3339 timestamp specifying the most recent update time of this booking.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// The RFC 3339 timestamp specifying the starting time of this booking.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_at")]
    public string? StartAt { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:Location">Location</see> object representing the location where the booked service is provided. Once set when the booking is created, its value cannot be changed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    [MaxLength(32)]
    public string? LocationId { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:Customer">Customer</see> object representing the customer receiving the booked service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    [MaxLength(192)]
    public string? CustomerId { get; init; }

    /// <summary>
    /// The free-text field for the customer to supply notes about the booking. For example, the note can be preferences that cannot be expressed by supported attributes of a relevant <see href="entity:CatalogObject">CatalogObject</see> instance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_note")]
    [MaxLength(4096)]
    public string? CustomerNote { get; init; }

    /// <summary>
    /// The free-text field for the seller to supply notes about the booking. For example, the note can be preferences that cannot be expressed by supported attributes of a specific <see href="entity:CatalogObject">CatalogObject</see> instance.
    /// This field should not be visible to customers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("seller_note")]
    [MaxLength(4096)]
    public string? SellerNote { get; init; }

    /// <summary>
    /// A list of appointment segments for this booking.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("appointment_segments")]
    public IReadOnlyList<AppointmentSegment?>? AppointmentSegments { get; init; }

    /// <summary>
    /// Additional time at the end of a booking.
    /// Applications should not make this field visible to customers of a seller.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transition_time_minutes")]
    public int? TransitionTimeMinutes { get; init; }

    /// <summary>
    /// Whether the booking is of a full business day.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("all_day")]
    public bool? AllDay { get; init; }

    /// <summary>
    /// Supported types of location where service is provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_type")]
    public BusinessAppointmentSettingsBookingLocationType? LocationType { get; init; }

    /// <summary>
    /// Information about a booking creator.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creator_details")]
    public BookingCreatorDetails? CreatorDetails { get; init; }

    /// <summary>
    /// Supported sources a booking was created from.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source")]
    public BookingBookingSource? Source { get; init; }

    /// <summary>
    /// Represents a postal address in a country.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/working-with-addresses">Working with Addresses</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public Address? Address { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

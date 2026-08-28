using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// A seller's business booking profile, including booking policy, appointment settings, etc.
/// </summary>
public record BusinessBookingProfile
{
    /// <summary>
    /// The ID of the seller, obtainable using the Merchants API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("seller_id")]
    [MaxLength(32)]
    public string? SellerId { get; init; }

    /// <summary>
    /// The RFC 3339 timestamp specifying the booking's creation time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// Indicates whether the seller is open for booking.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("booking_enabled")]
    public bool? BookingEnabled { get; init; }

    /// <summary>
    /// Choices of customer-facing time zone used for bookings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_timezone_choice")]
    public BusinessBookingProfileCustomerTimezoneChoice? CustomerTimezoneChoice { get; init; }

    /// <summary>
    /// Policies for accepting bookings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("booking_policy")]
    public BusinessBookingProfileBookingPolicy? BookingPolicy { get; init; }

    /// <summary>
    /// Indicates whether customers can cancel or reschedule their own bookings (<c>true</c>) or not (<c>false</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_user_cancel")]
    public bool? AllowUserCancel { get; init; }

    /// <summary>
    /// The service appointment settings, including where and how the service is provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("business_appointment_settings")]
    public BusinessAppointmentSettings? BusinessAppointmentSettings { get; init; }

    /// <summary>
    /// Indicates whether the seller's subscription to Square Appointments supports creating, updating or canceling an appointment through the API (<c>true</c>) or not (<c>false</c>) using seller permission.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("support_seller_level_writes")]
    public bool? SupportSellerLevelWrites { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

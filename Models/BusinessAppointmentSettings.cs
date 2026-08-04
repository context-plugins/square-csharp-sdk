using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// The service appointment settings, including where and how the service is provided.
/// </summary>
public record BusinessAppointmentSettings
{
    /// <summary>
    /// Types of the location allowed for bookings.
    /// See <see href="#type-businessappointmentsettingsbookinglocationtype">BusinessAppointmentSettingsBookingLocationType</see> for possible values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_types")]
    public IReadOnlyList<BusinessAppointmentSettingsBookingLocationType?>? LocationTypes { get; init; }

    /// <summary>
    /// Time units of a service duration for bookings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alignment_time")]
    public BusinessAppointmentSettingsAlignmentTime? AlignmentTime { get; init; }

    /// <summary>
    /// The minimum lead time in seconds before a service can be booked. A booking must be created at least this amount of time before its starting time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("min_booking_lead_time_seconds")]
    public int? MinBookingLeadTimeSeconds { get; init; }

    /// <summary>
    /// The maximum lead time in seconds before a service can be booked. A booking must be created at most this amount of time before its starting time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_booking_lead_time_seconds")]
    public int? MaxBookingLeadTimeSeconds { get; init; }

    /// <summary>
    /// Indicates whether a customer can choose from all available time slots and have a staff member assigned
    /// automatically (<c>true</c>) or not (<c>false</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("any_team_member_booking_enabled")]
    public bool? AnyTeamMemberBookingEnabled { get; init; }

    /// <summary>
    /// Indicates whether a customer can book multiple services in a single online booking.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("multiple_service_booking_enabled")]
    public bool? MultipleServiceBookingEnabled { get; init; }

    /// <summary>
    /// Types of daily appointment limits.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_appointments_per_day_limit_type")]
    public BusinessAppointmentSettingsMaxAppointmentsPerDayLimitType? MaxAppointmentsPerDayLimitType { get; init; }

    /// <summary>
    /// The maximum number of daily appointments per team member or per location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_appointments_per_day_limit")]
    public int? MaxAppointmentsPerDayLimit { get; init; }

    /// <summary>
    /// The cut-off time in seconds for allowing clients to cancel or reschedule an appointment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancellation_window_seconds")]
    public int? CancellationWindowSeconds { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancellation_fee_money")]
    public Money? CancellationFeeMoney { get; init; }

    /// <summary>
    /// The category of the seller’s cancellation policy.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancellation_policy")]
    public BusinessAppointmentSettingsCancellationPolicy? CancellationPolicy { get; init; }

    /// <summary>
    /// The free-form text of the seller's cancellation policy.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancellation_policy_text")]
    [MaxLength(65536)]
    public string? CancellationPolicyText { get; init; }

    /// <summary>
    /// Indicates whether customers has an assigned staff member (<c>true</c>) or can select s staff member of their choice (<c>false</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skip_booking_flow_staff_selection")]
    public bool? SkipBookingFlowStaffSelection { get; init; }
}

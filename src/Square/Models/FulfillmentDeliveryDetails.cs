using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Describes delivery details of an order fulfillment.
/// </summary>
public record FulfillmentDeliveryDetails
{
    /// <summary>
    /// Information about the fulfillment recipient.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recipient")]
    public FulfillmentRecipient? Recipient { get; init; }

    /// <summary>
    /// The schedule type of the delivery fulfillment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schedule_type")]
    public FulfillmentDeliveryDetailsOrderFulfillmentDeliveryDetailsScheduleType? ScheduleType { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment was placed.
    /// The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z").
    /// <para>
    /// Must be in RFC 3339 timestamp format, e.g., "2016-09-04T23:59:33.123Z".
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("placed_at")]
    public string? PlacedAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// that represents the start of the delivery period.
    /// The application can set this field while the fulfillment <c>state</c> is
    /// <c>PROPOSED</c>, <c>RESERVED</c>, or <c>PREPARED</c> (any time before the
    /// terminal state such as <c>COMPLETED</c>, <c>CANCELED</c>, and <c>FAILED</c>).
    /// <para>
    /// The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </para>
    /// <para>
    /// For fulfillments with the schedule type <c>ASAP</c>, this is automatically set
    /// to the current time plus <c>prep_time_duration</c>, if available.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliver_at")]
    public string? DeliverAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">duration</see>
    /// needed to prepare and deliver this fulfillment.
    /// The duration must be in RFC 3339 format (for example, "PT30M" for 30 minutes). Don't confuse
    /// "M" for months with "M" for minutes. "P5M" means 5 months, while "PT5M" means 5 minutes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prep_time_duration")]
    public string? PrepTimeDuration { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">duration</see>
    /// after <c>deliver_at</c> in which to deliver the order.
    /// Applications can set this field when the fulfillment <c>state</c> is
    /// <c>PROPOSED</c>, <c>RESERVED</c>, or <c>PREPARED</c> (any time before the terminal state
    /// such as <c>COMPLETED</c>, <c>CANCELED</c>, and <c>FAILED</c>).
    /// <para>
    /// The duration must be in RFC 3339 format (for example, "PT30M" for 30 minutes). Don't confuse
    /// "M" for months with "M" for minutes. "P5M" means 5 months, while "PT5M" means 5 minutes.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delivery_window_duration")]
    public string? DeliveryWindowDuration { get; init; }

    /// <summary>
    /// Provides additional instructions about the delivery fulfillment.
    /// It is displayed in the Square Point of Sale application and set by the API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("note")]
    [MaxLength(550)]
    public string? Note { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicates when the seller completed the fulfillment.
    /// This field is automatically set when  fulfillment <c>state</c> changes to <c>COMPLETED</c>.
    /// The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("completed_at")]
    public string? CompletedAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicates when the seller started processing the fulfillment.
    /// This field is automatically set when the fulfillment <c>state</c> changes to <c>RESERVED</c>.
    /// The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("in_progress_at")]
    public string? InProgressAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment was rejected. This field is
    /// automatically set when the fulfillment <c>state</c> changes to <c>FAILED</c>.
    /// The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rejected_at")]
    public string? RejectedAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the seller marked the fulfillment as ready for
    /// courier pickup. This field is automatically set when the fulfillment <c>state</c> changes
    /// to PREPARED.
    /// The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ready_at")]
    public string? ReadyAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment was delivered to the recipient.
    /// The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delivered_at")]
    public string? DeliveredAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment was canceled. This field is automatically
    /// set when the fulfillment <c>state</c> changes to <c>CANCELED</c>.
    /// <para>
    /// The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z").
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("canceled_at")]
    public string? CanceledAt { get; init; }

    /// <summary>
    /// The delivery cancellation reason. Max length: 100 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancel_reason")]
    [MaxLength(100)]
    public string? CancelReason { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when an order can be picked up by the courier for delivery.
    /// The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("courier_pickup_at")]
    public string? CourierPickupAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">duration</see>
    /// after <c>courier_pickup_at</c> in which the courier should pick up the order.
    /// The duration must be in RFC 3339 format (for example, "PT30M" for 30 minutes). Don't confuse
    /// "M" for months with "M" for minutes. "P5M" means 5 months, while "PT5M" means 5 minutes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("courier_pickup_window_duration")]
    public string? CourierPickupWindowDuration { get; init; }

    /// <summary>
    /// Whether the delivery is preferred to be no contact.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_no_contact_delivery")]
    public bool? IsNoContactDelivery { get; init; }

    /// <summary>
    /// A note to provide additional instructions about how to deliver the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dropoff_notes")]
    [MaxLength(550)]
    public string? DropoffNotes { get; init; }

    /// <summary>
    /// The name of the courier provider.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("courier_provider_name")]
    [MaxLength(255)]
    public string? CourierProviderName { get; init; }

    /// <summary>
    /// The support phone number of the courier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("courier_support_phone_number")]
    [MaxLength(17)]
    public string? CourierSupportPhoneNumber { get; init; }

    /// <summary>
    /// The identifier for the delivery created by Square.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("square_delivery_id")]
    [MaxLength(50)]
    public string? SquareDeliveryId { get; init; }

    /// <summary>
    /// The identifier for the delivery created by the third-party courier service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("external_delivery_id")]
    [MaxLength(50)]
    public string? ExternalDeliveryId { get; init; }

    /// <summary>
    /// The flag to indicate the delivery is managed by a third party (ie DoorDash), which means
    /// we may not receive all recipient information for PII purposes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("managed_delivery")]
    public bool? ManagedDelivery { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

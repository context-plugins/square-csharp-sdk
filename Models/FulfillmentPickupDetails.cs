using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Contains details necessary to fulfill a pickup order.
/// </summary>
public record FulfillmentPickupDetails
{
    /// <summary>
    /// Information about the fulfillment recipient.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recipient")]
    public FulfillmentRecipient? Recipient { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when this fulfillment expires if it is not marked in progress. The timestamp must be
    /// in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z"). The expiration time can only be set
    /// up to 7 days in the future. If <c>expires_at</c> is not set, any new payments attached to the order
    /// are automatically completed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expires_at")]
    public string? ExpiresAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">duration</see>
    /// after which an in-progress pickup fulfillment is automatically moved
    /// to the <c>COMPLETED</c> state. The duration must be in RFC 3339 format (for example, "PT4H" for 4 hours).
    /// <para>
    /// If not set, this pickup fulfillment remains in progress until it is canceled or completed.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auto_complete_duration")]
    public string? AutoCompleteDuration { get; init; }

    /// <summary>
    /// The schedule type of the pickup fulfillment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schedule_type")]
    public FulfillmentPickupDetailsScheduleType? ScheduleType { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// that represents the start of the pickup window. Must be in RFC 3339 timestamp format, e.g.,
    /// "2016-09-04T23:59:33.123Z".
    /// <para>
    /// For fulfillments with the schedule type <c>ASAP</c>, this is automatically set
    /// to the current time plus <c>prep_time_duration</c>, if available.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pickup_at")]
    public string? PickupAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">duration</see>
    /// in which the order should be picked up after the <c>pickup_at</c> timestamp.
    /// The duration must be in RFC 3339 format (for example, "PT30M" for 30 minutes). Don't confuse
    /// "M" for months with "M" for minutes. "P5M" means 5 months, while "PT5M" means 5 minutes.
    /// <para>
    /// Can be used as an informational guideline for merchants.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pickup_window_duration")]
    public string? PickupWindowDuration { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">duration</see>
    /// needed to prepare this fulfillment.
    /// The duration must be in RFC 3339 format (for example, "PT30M" for 30 minutes). Don't confuse
    /// "M" for months with "M" for minutes. "P5M" means 5 months, while "PT5M" means 5 minutes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prep_time_duration")]
    public string? PrepTimeDuration { get; init; }

    /// <summary>
    /// A note to provide additional instructions about the pickup
    /// fulfillment displayed in the Square Point of Sale application and set by the API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("note")]
    [MaxLength(500)]
    public string? Note { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment was placed. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("placed_at")]
    public string? PlacedAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment was marked in progress. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accepted_at")]
    public string? AcceptedAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment was rejected. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rejected_at")]
    public string? RejectedAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment is marked as ready for pickup. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ready_at")]
    public string? ReadyAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment expired. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expired_at")]
    public string? ExpiredAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment was picked up by the recipient. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("picked_up_at")]
    public string? PickedUpAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment was canceled. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("canceled_at")]
    public string? CanceledAt { get; init; }

    /// <summary>
    /// A description of why the pickup was canceled. The maximum length: 100 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancel_reason")]
    [MaxLength(100)]
    public string? CancelReason { get; init; }

    /// <summary>
    /// If set to <c>true</c>, indicates that this pickup order is for curbside pickup, not in-store pickup.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_curbside_pickup")]
    public bool? IsCurbsidePickup { get; init; }

    /// <summary>
    /// Specific details for curbside pickup.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("curbside_pickup_details")]
    public FulfillmentPickupDetailsCurbsidePickupDetails? CurbsidePickupDetails { get; init; }
}

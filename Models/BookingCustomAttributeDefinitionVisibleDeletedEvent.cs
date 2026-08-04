using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Published when a booking <see href="entity:CustomAttributeDefinition">custom attribute definition</see>
/// with the <c>visibility</c> field set to <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c> is deleted.
/// An application that subscribes to this event is notified when a booking custom attribute definition is deleted
/// by any application for which the subscribing application has read access to the booking custom attribute definition.
/// </summary>
public record BookingCustomAttributeDefinitionVisibleDeletedEvent
{
    /// <summary>
    /// The ID of the seller associated with the event that triggered the event notification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; init; }

    /// <summary>
    /// The type of this event. The value is <c>"booking.custom_attribute_definition.visible.deleted"</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// A unique ID for the event notification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event_id")]
    public string? EventId { get; init; }

    /// <summary>
    /// The timestamp that indicates when the event notification was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// Represents an object in the CustomAttributeDefinition event notification
    /// payload that contains the affected custom attribute definition.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public CustomAttributeDefinitionEventData? Data { get; init; }
}

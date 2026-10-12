using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Published when a customer <see href="entity:CustomAttribute">custom attribute</see> that is visible
/// to all applications is deleted. A notification is sent when any application deletes a custom attribute
/// whose <c>visibility</c> is <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>.
/// <para>
/// This event is replaced by
/// <see href="webhook:customer.custom_attribute.visible.deleted">customer.custom_attribute.visible.deleted</see>,
/// which applies to custom attributes that are visible to the subscribing application.
/// </para>
/// </summary>
public record CustomerCustomAttributeDeletedPublicEvent
{
    /// <summary>
    /// The ID of the seller associated with the event that triggered the event notification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; init; }

    /// <summary>
    /// The type of this event. The value is <c>"customer.custom_attribute.public.deleted"</c>.
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public CustomAttributeEventData? Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

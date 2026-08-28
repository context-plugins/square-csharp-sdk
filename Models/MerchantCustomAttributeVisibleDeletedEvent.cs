using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Published when a merchant <see href="entity:CustomAttribute">custom attribute</see> with
/// the <c>visibility</c> field set to <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c> is deleted.
/// An application that subscribes to this event is notified when a merchant custom attribute is deleted
/// by any application for which the subscribing application has read access to the merchant custom attribute.
/// </summary>
public record MerchantCustomAttributeVisibleDeletedEvent
{
    /// <summary>
    /// The ID of the seller associated with the event that triggered the event notification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; init; }

    /// <summary>
    /// The type of this event. The value is <c>"merchant.custom_attribute.visible.deleted"</c>.
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

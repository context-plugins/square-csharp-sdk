using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Published when a customer <see href="entity:CustomAttribute">custom attribute</see> that is visible to the
/// subscribing application is deleted. A notification is sent when:
/// - Your application deletes a custom attribute owned by your application, regardless of the <c>visibility</c> setting.
/// - Any application deletes a custom attribute whose <c>visibility</c> is <c>VISIBILITY_READ_ONLY</c>
/// or <c>VISIBILITY_READ_WRITE_VALUES</c>.
/// <para>
/// Custom attributes set to <c>VISIBILITY_READ_WRITE_VALUES</c> can be deleted by any application, but those set to
/// <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_HIDDEN</c> can only be deleted by the owner. Custom attributes are owned
/// by the application that created the corresponding <see href="entity:CustomAttributeDefinition">custom attribute definition</see>.
/// </para>
/// </summary>
public record CustomerCustomAttributeVisibleDeletedEvent
{
    /// <summary>
    /// The ID of the seller associated with the event that triggered the event notification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; init; }

    /// <summary>
    /// The type of this event. The value is <c>"customer.custom_attribute.visible.deleted"</c>.
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

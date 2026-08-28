using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Published when a customer <see href="entity:CustomAttributeDefinition">custom attribute definition</see>
/// created by the subscribing application is updated. A custom attribute definition can only be updated by
/// the application that created it.
/// </summary>
public record CustomerCustomAttributeDefinitionOwnedUpdatedEvent
{
    /// <summary>
    /// The ID of the seller associated with the event that triggered the event notification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; init; }

    /// <summary>
    /// The type of this event. The value is <c>"customer.custom_attribute_definition.owned.updated"</c>.
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

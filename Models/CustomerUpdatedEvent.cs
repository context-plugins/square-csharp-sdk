using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Published when a <see href="entity:Customer">customer</see> is updated. For more information, see <see href="https://developer.squareup.com/docs/customers-api/use-the-api/customer-webhooks">Use Customer Webhooks</see>.
/// <para>
/// Updates to the 'segment_ids' customer field does not invoke a <c>customer.updated</c> event. In addition, the <c>customer</c> object in the event notification does not include this field.
/// </para>
/// </summary>
public record CustomerUpdatedEvent
{
    /// <summary>
    /// The ID of the seller associated with the event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; init; }

    /// <summary>
    /// The type of event. For this object, the value is <c>customer.updated</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// The unique ID of the event, which is used for <see href="https://developer.squareup.com/docs/webhooks/step4manage#webhooks-best-practices">idempotency support</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event_id")]
    public string? EventId { get; init; }

    /// <summary>
    /// The timestamp of when the event was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The data associated with the event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public CustomerUpdatedEventData? Data { get; init; }
}

using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Published when a <see href="entity:LoyaltyProgram">loyalty program</see> is updated.
/// </summary>
public record LoyaltyProgramUpdatedEvent
{
    /// <summary>
    /// The ID of the Square seller associated with the event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; init; }

    /// <summary>
    /// The type of event. For this event, the value is <c>loyalty.program.updated</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// The unique ID for the event, which is used for
    /// <see href="https://developer.squareup.com/docs/webhooks/step4manage#webhooks-best-practices">idempotency support</see>.
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
    /// The data associated with a <c>loyalty.program.updated</c> event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public LoyaltyProgramUpdatedEventData? Data { get; init; }
}

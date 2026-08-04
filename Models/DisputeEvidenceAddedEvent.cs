using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Published when evidence is added to a <see href="entity:Dispute">Dispute</see>
/// from the Disputes Dashboard in the Seller Dashboard, the Square Point of Sale app,
/// or by calling either <see href="api-endpoint:Disputes-CreateDisputeEvidenceFile">CreateDisputeEvidenceFile</see> or <see href="api-endpoint:Disputes-CreateDisputeEvidenceText">CreateDisputeEvidenceText</see>.
/// </summary>
public record DisputeEvidenceAddedEvent
{
    /// <summary>
    /// The ID of the target merchant associated with the event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; init; }

    /// <summary>
    /// The ID of the target location associated with the event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// The type of event this represents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// A unique ID for the event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event_id")]
    public string? EventId { get; init; }

    /// <summary>
    /// Timestamp of when the event was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public DisputeEvidenceAddedEventData? Data { get; init; }
}
